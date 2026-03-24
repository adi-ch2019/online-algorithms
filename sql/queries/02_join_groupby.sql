-- Query 5: With HAVING clause (authors with more than 1 book)
SELECT a.author_name, COUNT(b.book_id) as book_count
FROM authors a
JOIN books b ON a.author_id = b.author_id
GROUP BY a.author_id, a.author_name
-- HAVING COUNT(b.book_id) > 0
HAVING COUNT(b.book_id) > 1
--ORDER BY BOOK_COUNT DESC