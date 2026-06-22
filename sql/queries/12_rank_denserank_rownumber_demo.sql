-- Image 12: Demonstrate RANK(), DENSE_RANK(), ROW_NUMBER() differences
BEGIN TRANSACTION;

-- Create a temporary sales summary
WITH BookSales AS (
    SELECT 
        b.book_id,
        b.book_name,
        a.author_name,
        COALESCE(SUM(o.amount), 0) as total_sales
    FROM books b
    JOIN authors a ON b.author_id = a.author_id
    LEFT JOIN orders o ON b.book_id = o.book_id
    GROUP BY b.book_id, b.book_name, a.author_name
)
SELECT 
    book_name,
    author_name,
    total_sales,
    ROW_NUMBER() OVER (ORDER BY total_sales DESC) as row_number_rank,
    RANK() OVER (ORDER BY total_sales DESC) as rank_with_gaps,
    DENSE_RANK() OVER (ORDER BY total_sales DESC) as dense_rank_no_gaps
FROM BookSales
ORDER BY total_sales DESC;

-- Add more test data to demonstrate ties
INSERT INTO orders (order_id, person_id, book_id, sale_year, sale_date, amount) VALUES
(100, 999, 101, 2024, '2024-01-01', 500),
(101, 998, 101, 2024, '2024-01-02', 500);

-- Show the difference clearly with ties
WITH BookSales AS (
    SELECT 
        b.book_id,
        b.book_name,
        COALESCE(SUM(o.amount), 0) as total_sales
    FROM books b
    LEFT JOIN orders o ON b.book_id = o.book_id
    GROUP BY b.book_id, b.book_name
)
SELECT 
    book_name,
    total_sales,
    ROW_NUMBER() OVER (ORDER BY total_sales DESC) as "ROW_NUMBER()",
    RANK() OVER (ORDER BY total_sales DESC) as "RANK()",
    DENSE_RANK() OVER (ORDER BY total_sales DESC) as "DENSE_RANK()",
    CASE 
        WHEN total_sales = LAG(total_sales) OVER (ORDER BY total_sales DESC) THEN '← Tie with above'
        ELSE ''
    END as note
FROM BookSales
ORDER BY total_sales DESC;

ROLLBACK;
-- COMMIT would save the test data