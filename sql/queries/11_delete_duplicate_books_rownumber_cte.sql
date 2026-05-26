-- Delete duplicate books using CTE with ROW_NUMBER()
BEGIN TRANSACTION;

-- First, let's see the current books
SELECT 'Before deletion - Books table' as Status;
SELECT * FROM books ORDER BY book_id;

-- Create duplicates for demonstration
INSERT INTO books (book_id, book_name, author_id, category_id) VALUES
(201, 'How to be Happy', 1, 1),
(202, '7 Habits for Success', 1, 1);

-- Show books with duplicates
SELECT 'Books with potential duplicates' as Status;
SELECT book_name, COUNT(*) as duplicate_count
FROM books
GROUP BY book_name
HAVING COUNT(*) > 1;

-- Using CTE with ROW_NUMBER() to identify duplicates
WITH CTE_Duplicates AS (
    SELECT 
        book_id,
        book_name,
        ROW_NUMBER() OVER (
            PARTITION BY book_name 
            ORDER BY book_id
        ) AS rnk
    FROM books
)
-- Delete duplicate rows (keep only rnk = 1)
DELETE FROM books
WHERE book_id IN (
    SELECT book_id 
    FROM CTE_Duplicates 
    WHERE rnk > 1
);

-- Show results after deletion
SELECT 'After deletion - No duplicates' as Status;
SELECT * FROM books ORDER BY book_id;

-- ROLLBACK to see original state (or COMMIT to save)
ROLLBACK;
-- Use COMMIT if you want to permanently delete