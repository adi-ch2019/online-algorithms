-- Query 2: JOIN + GROUP BY
-- Count books per author

SELECT * FROM AUTHORS;

SELECT * FROM BOOKS;

SELECT 
    a.author_name as AuthorName,
    COUNT(b.book_id) as BookCount
FROM authors a
LEFT JOIN books b ON a.author_id = b.author_id
GROUP BY a.author_id, a.author_name
ORDER BY BookCount DESC;