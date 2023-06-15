const products = [
  {
    id: 1,
    title: "Evolution Serverless Containers",
    category: "Разработчики",
  },
  {
    id: 2,
    title: "Evolution Serverless Functions",
    category: "Разработчики",
  },
  {
    id: 3,
    title: "Evolution Container Registry",
    category: "Разработчики",
  },
  {
    id: 4,
    title: "Evolution API Gateway",
    category: "Разработчики",
  },
];

const getProducts = async function () {
  return Promise.resolve(products);
};

exports.getProducts = getProducts;
