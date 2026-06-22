SELECT 
    person_id,
    MIN(sale_date) as first_purchase,
    (
        SELECT sale_date 
        FROM orders o2 
        WHERE o2.person_id = o.person_id 
        GROUP BY sale_date 
        ORDER BY sale_date 
        LIMIT 1 OFFSET 1
    ) as second_purchase,
    COUNT(DISTINCT sale_date) as total_orders
FROM orders o
GROUP BY person_id
ORDER BY person_id;