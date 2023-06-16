var Products = require("../models/Product");

exports.index = async function (req, res) {
  const products = await Products.getProducts();
  console.log("Retrieved Products");
  res.json(products);
};
