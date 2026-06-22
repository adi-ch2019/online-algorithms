WITH customer_first_purchase AS (
    SELECT 
        person_id,
        MIN(sale_date) as first_purchase_date
    FROM orders
    GROUP BY person_id
)
SELECT 
    o.sale_date,
    COUNT(DISTINCT cfp.person_id) as new_customers
FROM orders o
LEFT JOIN customer_first_purchase cfp 
    ON o.person_id = cfp.person_id 
    AND o.sale_date = cfp.first_purchase_date
GROUP BY o.sale_date
ORDER BY o.sale_date;
