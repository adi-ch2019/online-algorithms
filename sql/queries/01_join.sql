-- Books of every Author
-- Retrieve all authors and their books

SELECT 
    a.author_name,
    b.book_name
FROM authors a
LEFT JOIN books b ON a.author_id = b.author_id
ORDER BY a.author_name, b.book_name;