SELECT * FROM AUTHORS;
SELECT * FROM BOOKS;

-- Query 1: Simple JOIN to get all books with author names
SELECT a.author_name, b.book_name
FROM authors a
JOIN books b ON a.author_id = b.author_id
ORDER BY a.author_name, b.book_name;