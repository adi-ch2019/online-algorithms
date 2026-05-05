-- Query 1: Using CTE with ROW_NUMBER
WITH author_yearly_sales AS (
    SELECT 
        a.author_name,
        b.book_id,
        b.book_name,
        o.sale_year,
        SUM(o.amount) as yearly_amount
    FROM authors a
    JOIN books b ON a.author_id = b.author_id
    JOIN orders o ON b.book_id = o.book_id
    GROUP BY a.author_name, b.book_id, b.book_name, o.sale_year
),
ranked_sales AS (
    SELECT 
        *,
        ROW_NUMBER() OVER (PARTITION BY sale_year ORDER BY yearly_amount DESC) as rn
    FROM author_yearly_sales
)
SELECT author_name, book_id, book_name, sale_year, yearly_amount
FROM ranked_sales
WHERE rn = 1
ORDER BY sale_year;

-- Query 3: Using DENSE_RANK
WITH author_sales AS (
    SELECT 
        a.author_name,
        b.book_id,
        b.book_name,
        o.sale_year,
        SUM(o.amount) as yearly_amount
    FROM authors a
    JOIN books b ON a.author_id = b.author_id
    JOIN orders o ON b.book_id = o.book_id
    GROUP BY a.author_name, b.book_id, b.book_name, o.sale_year
),
ranked AS (
    SELECT 
        *,
        DENSE_RANK() OVER (PARTITION BY sale_year ORDER BY yearly_amount DESC) as dr
    FROM author_sales
)
SELECT author_name, book_id, book_name, sale_year, yearly_amount
FROM ranked
WHERE dr = 1;
