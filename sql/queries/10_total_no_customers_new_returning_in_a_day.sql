WITH ranked_orders AS (
    SELECT 
        person_id,
        sale_date,
        ROW_NUMBER() OVER (PARTITION BY person_id ORDER BY sale_date) as rn
    FROM orders
)
SELECT 
    sale_date,
    COUNT(DISTINCT person_id) as total_customers,
    COUNT(DISTINCT CASE WHEN rn = 1 THEN person_id END) as new_customers,
    COUNT(DISTINCT CASE WHEN rn > 1 THEN person_id END) as returning_customers
FROM ranked_orders
GROUP BY sale_date
ORDER BY sale_date;