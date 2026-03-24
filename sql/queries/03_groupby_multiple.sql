-- Image 3: Individual Book Sales of every Author
-- Query 5: With average sales per book
SELECT 
    a.author_name,
    b.book_name,
    SUM(o.amount) as total_amount,
    AVG(o.amount) as avg_sale_amount,
    COUNT(o.order_id) as number_of_sales
FROM authors a
JOIN books b ON a.author_id = b.author_id
LEFT JOIN orders o ON b.book_id = o.book_id
GROUP BY a.author_name, b.book_name;