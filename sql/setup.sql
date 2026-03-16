-- Drop existing tables
DROP TABLE IF EXISTS orders;
DROP TABLE IF EXISTS daily_sales;
DROP TABLE IF EXISTS books;
DROP TABLE IF EXISTS authors;
DROP TABLE IF EXISTS category;

-- Create authors table
CREATE TABLE authors (
    author_id INTEGER PRIMARY KEY,
    author_name TEXT NOT NULL
);

-- Create category table
CREATE TABLE category (
    category_id INTEGER PRIMARY KEY,
    category_name TEXT NOT NULL
);

-- Create books table
CREATE TABLE books (
    book_id INTEGER PRIMARY KEY,
    book_name TEXT NOT NULL,
    author_id INTEGER,
    category_id INTEGER,
    FOREIGN KEY (author_id) REFERENCES authors(author_id),
    FOREIGN KEY (category_id) REFERENCES category(category_id)
);

-- Create orders table
CREATE TABLE orders (
    order_id INTEGER PRIMARY KEY,
    person_id INTEGER,
    book_id INTEGER,
    sale_year INTEGER,
    sale_date TEXT,
    amount REAL,
    FOREIGN KEY (book_id) REFERENCES books(book_id)
);

-- Create daily_sales table
CREATE TABLE daily_sales (
    id INTEGER PRIMARY KEY,
    sale_date TEXT,
    daily_amount REAL
);

-- Insert sample data
INSERT INTO authors (author_id, author_name) VALUES
(1, 'John Smith'),
(2, 'Jane Doe'),
(3, 'Bob Johnson');

INSERT INTO category (category_id, category_name) VALUES
(1, 'Self-Help'),
(2, 'Relationships');

INSERT INTO books (book_id, book_name, author_id, category_id) VALUES
(101, 'How to be Happy', 1, 1),
(102, '7 Habits for Success', 1, 1),
(103, 'Build a Good Body', 2, 1),
(104, 'Messages in Water', 3, 2),
(105, 'Love Languages', 3, 2);

INSERT INTO orders (order_id, person_id, book_id, sale_year, sale_date, amount) VALUES
(1, 101, 101, 2023, '2023-01-15', 29.99),
(2, 102, 101, 2023, '2023-01-20', 29.99),
(3, 103, 102, 2023, '2023-02-10', 34.99),
(4, 104, 103, 2023, '2023-02-15', 24.99),
(5, 105, 104, 2023, '2023-03-01', 19.99);

INSERT INTO daily_sales (id, sale_date, daily_amount) VALUES
(1, '2023-01-15', 1000.00),
(2, '2023-01-16', 1500.00),
(3, '2023-01-17', 1200.00);