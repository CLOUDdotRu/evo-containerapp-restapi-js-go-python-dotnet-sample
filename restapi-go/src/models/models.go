package models

import (
	"fmt"
)

func init() {
	fmt.Println("Initialize - models package")
}

type Product struct {
	Id     		int  		`json:"id"`
	Title  		string  	`json:"title"`
	Category 	string  	`json:"category"`
}

func GetProducts() []Product {

	var products []Product

	product1 := Product{Id: 1, Title: "Evolution Serverless Containers", Category: "Разработчики"}
	products = append(products, product1)

	product2 := Product{Id: 2, Title: "Evolution Serverless Functions", Category: "Разработчики"}
	products = append(products, product2)

	product3 := Product{Id: 3, Title: "Evolution Container Registry", Category: "Разработчики"}
	products = append(products, product3)

	product4 := Product{Id: 4, Title: "Evolution API Gateway", Category: "Разработчики"}
	products = append(products, product4)

	return products

};
