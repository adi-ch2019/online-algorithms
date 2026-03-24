-- Image 4: Total Book Count and Sales in every Category

-- Query 1: Multiple CTEs for book count and sales
WITH book_count AS (
    SELECT 
        category_id,
        COUNT(*) as total_books
    FROM books
    GROUP BY category_id
),
category_sales AS (
    SELECT 
        b.category_id,
        COALESCE(SUM(o.amount), 0) as total_sales
    FROM books b
    LEFT JOIN orders o ON b.book_id = o.book_id
    GROUP BY b.category_id
)
SELECT 
    c.category_name,
    bc.total_books,
    cs.total_sales
FROM category c
LEFT JOIN book_count bc ON c.category_id = bc.category_id
LEFT JOIN category_sales cs ON c.category_id = cs.category_id
ORDER BY c.category_name;
