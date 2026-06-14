-- Query 1: Using difference of row numbers technique
WITH numbered_days AS (
    SELECT 
        sale_date,
        daily_amount,
        ROW_NUMBER() OVER (ORDER BY sale_date) as rn
    FROM daily_sales
),
date_diff AS (
    SELECT 
        sale_date,
        daily_amount,
        DATE(sale_date) - rn as group_id
    FROM numbered_days
)
SELECT 
    MIN(sale_date) as series_start_day,
    MAX(sale_date) as series_end_day,
    COUNT(*) as series_length_in_days,
    SUM(daily_amount) as series_total_amount
FROM date_diff
GROUP BY group_id
ORDER BY series_start_day;

-- Query 2: Using LAG to identify gaps
WITH gaps AS (
    SELECT 
        sale_date,
        daily_amount,
        CASE 
            WHEN DATE(sale_date) - INTERVAL '1 day' = LAG(sale_date) OVER (ORDER BY sale_date) 
            THEN 0 ELSE 1 
        END as new_group
    FROM daily_sales
),
groups AS (
    SELECT 
        sale_date,
        daily_amount,
        SUM(new_group) OVER (ORDER BY sale_date) as group_id
    FROM gaps
)
SELECT 
    MIN(sale_date) as series_start_day,
    MAX(sale_date) as series_end_day,
    COUNT(*) as series_length_in_days,
    SUM(daily_amount) as series_total_amount
FROM groups
GROUP BY group_id
ORDER BY series_start_day;