CREATE TABLE users (
    id INT PRIMARY KEY IDENTITY,
    username VARCHAR(255) NOT NULL,
    password VARCHAR(255) NOT NULL,
    role  VARCHAR(255) NOT NULL
);

CREATE TABLE queue_numbers(
id INT PRIMARY KEY IDENTITY,
number INT NOT NULL,
date DATE NOT NULL,
status VARCHAR(20) NOT NULL,
user_id INT,
FOREIGN KEY (user_id) REFERENCES users(id)
);


Select id, username, password, role from users;

DROP  TABLE users;

DELETE queue_numbers