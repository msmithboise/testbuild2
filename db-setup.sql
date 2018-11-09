--  CREATE TABLE Cats (
--    id int NOT NULL AUTO_INCREMENT,
--    name VARCHAR(255) NOT NULL,
--    description VARCHAR(255) NOT NULL,
--    PRIMARY KEY(id)
--  );

INSERT INTO cats (name, description) 
VALUES ("Grey Cat", "Super fuzzy!");

-- -- SELECT * FROM frenchfries;

-- -- ALTER TABLE frenchfries MODIFY COLUMN price DECIMAL(10,2);

-- -- UPDATE frenchfries SET 
-- --   price = 7.99, 
-- --   name = "The Plain Jane with Cheese", 
-- --   description = "Burger on a bun with cheese"
-- --   WHERE id = 1;

-- -- DELETE FROM frenchfries WHERE id = 1;

-- -- User Table Creation

-- CREATE TABLE users(
--     id VARCHAR(255) NOT NULL,
--     username VARCHAR(20) NOT NULL,
--     email VARCHAR(255) NOT NULL,
--     has VARCHAR(255),
--     PRIMARY KEY (id),
--     UNIQUE KEY email (email)
-- );

-- -- favorites table

-- CREATE TABLE userburgers(
--     id int NOT NULL AUTO_INCREMENT,
--     burgerId int NOT NULL,
--     userId VARCHAR(255) NOT NULL,

--     PRIMARY KEY (id)
--     INDEX (userId)

-- FOREIGN KEY(userId)
-- REFERENCES user(id)
-- ON DELETE CASCADE,
-- -- if userId is deleted, remove the references

-- FOREIGN KEY(burgerId)
-- REFERENCES (burgerId)
-- ON DELETE CASCADE,
-- );


-- DROP TABLE cats;



-- CREATE TABLE keeps (
--     id int NOT NULL AUTO_INCREMENT,
--     name VARCHAR(20) NOT NULL,
--     description VARCHAR(255) NOT NULL,
--     imgUrl VARCHAR(255) NOT NULL,
--     userId VARCHAR(255) NOT NULL,
--     INDEX userId (userId),
--     FOREIGN KEY (userId)
--         REFERENCES users(id)
--         ON DELETE CASCADE,  
--     PRIMARY KEY (id)
-- );