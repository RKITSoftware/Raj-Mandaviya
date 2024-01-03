-- Insert authors
INSERT INTO AUT01 (T01F01, T01F02) VALUES
(1, 'JK Rowling'),
(2, 'William Shakespeare'),
(3, 'Chetan Bhagat');

-- Insert books
INSERT INTO BOO01 (O01F02, O01F03, O01F04) VALUES
('Harry Potter', 1, 'Fiction'),
('Harry Potter 2', 1, 'Fiction'),
('Hamlet', 2, 'Drama'),
('Half Girlfriend', 3, 'Love-Story');

-- Insert users
INSERT INTO USE01 (E01F02, E01F03) VALUES
('Raj', 'raj123'),
('aum', 'aum123'),
('dev', 'dev123');

-- Insert borrowed books
INSERT INTO BOO02 (O02F02, O02F03, O02F04, O02F05) VALUES
(1, 2, '2023-11-28', '2023-12-13'), # Return Date = Borrow Date = 15 days
(2, 3, '2023-11-26', '2023-12-11'),
(3, 1, '2023-11-25', '2023-12-10');

-- Insert sample transactions
INSERT INTO TRA01 (A01F02, A01F03, A01F04) VALUES
(1, 'B', '2023-11-28'),
(2, 'B', '2023-11-26'),
(3, 'B', '2023-11-25'),
(1, 'R', '2023-11-20');
