// models/product.js
const pool = require('../services/db');

const getAllProducts = () => {
  return new Promise((resolve, reject) => {
    pool.query('SELECT * FROM products', (err, results) => {
      if (err) {
        reject(err);
      } else {
        resolve(results);
      }
    });
  });
}

const createProduct = (product) => {
  const { name, description, measurement_type, quantity, expense_price, retail_price, arrival_date } = product;
  return new Promise((resolve, reject) => {
    pool.query('INSERT INTO products (name, description, measurement_type, quantity, expense_price, retail_price, arrival_date) VALUES (?, ?, ?, ?, ?, ?, ?)', 
    [name, description, measurement_type, quantity, expense_price, retail_price, arrival_date], (err, results) => {
      if (err) reject(err);
      else resolve(results);
    });
  });
};



const updateProduct = (id, product) => {
  const { name, description, measurement_type, quantity, expense_price, retail_price, arrival_date } = product;
  return new Promise((resolve, reject) => {
    pool.query('UPDATE products SET name = ?, description = ?, measurement_type = ?, quantity = ?, expense_price = ?, retail_price = ?, arrival_date = ? WHERE id = ?',
      [name, description, measurement_type, quantity, expense_price, retail_price, arrival_date, id],
      (err, results) => {
        if (err) {
          console.error("Error updating product:", err);
          reject(err);
        } else {
          resolve(results);
        }
      }
    );
  });
};

const deleteProduct = (id) => {
  return new Promise((resolve, reject) => {
    pool.query('DELETE FROM products WHERE id = ?', [id], (err, results) => {
      if (err) reject(err);
      else resolve(results);
    });
  });
};

module.exports = {
  getAllProducts,
  createProduct,
  updateProduct,
  deleteProduct,
};

