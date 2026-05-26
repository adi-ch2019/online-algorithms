-- Query 2: Using ROW_NUMBER instead of DENSE_RANK
WITH book_sales AS (
    SELECT 
        b.book_id,
        b.book_name,
        b.category_id,
        c.category_name,
        COALESCE(SUM(o.amount), 0) as sales_per_book
    FROM books b
    JOIN category c ON b.category_id = c.category_id
    LEFT JOIN orders o ON b.book_id = o.book_id
    GROUP BY b.book_id, b.book_name, b.category_id, c.category_name
),
ranked_books AS (
    SELECT 
        *,
        ROW_NUMBER() OVER (PARTITION BY category_id ORDER BY sales_per_book DESC) as sales_rank
    FROM book_sales
)
SELECT book_id, book_name, category_id, category_name, sales_per_book, sales_rank
FROM ranked_books
WHERE sales_rank <= 2;