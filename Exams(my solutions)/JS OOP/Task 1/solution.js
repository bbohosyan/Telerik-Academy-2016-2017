function solve() {
    class Product {
        constructor(productType, name, price) {
            this.productType = productType;
            this.name = name;
            this.price = price;
        }

        get productType() {
            return this._productType;
        }
        set productType(value) {
            if (typeof value != "string") {
                throw new Error("productProductType");
            }
            this._productType = value;
        }

        get name() {
            return this._name;
        }
        set name(value) {
            if (typeof value != "string") {
                throw new Error("productName");
            }
            this._name = value;
        }

        get price() {
            return this._price;
        }
        set price(value) {
            if (typeof value != "number") {
                throw new Error("productNumber");
            }
            this._price = value;
        }
    }

    class ShoppingCart {
        constructor() {
            this.products = [];
        }

        add(product) {
            if (!(product instanceof Product)) {
                throw new Error("Must add only Products");
            }
            this.products.push(product);

            return this;
        }

        remove(product) {
            if (!(product instanceof Product)) {
                throw new Error("Must add only Products");
            }
            if (this.products.length === 0) {
                throw new Error("No products in ShoppingCart");
            }
            var isSuchAnItem = false;
            for (var index = 0; index < this.products.length; index++) {
                if (product.name == this.products[index].name && product.price == this.products[index].price && product.productType == this.products[index].productType) {
                    this.products.splice(index, 1);
                    isSuchAnItem = true;
                }
            }
            if (!isSuchAnItem) {
                throw new Error("No such an item in ShoppingCart");
            }
        }
        showCost() {
            if (this.products.length === 0) {
                return 0;
            }
            var allProductsPrices = 0;
            for (var index = 0; index < this.products.length; index++) {
                allProductsPrices += this.products[index].price;
            }
            return allProductsPrices;
        }

        showProductTypes() {
            if (this.products.length === 0) {
                return [];
            }
            // let uniq = [];
            // this.products.forEach(x => uniq[x.productType] = true);
            // uniq.sort(function(a, b) {
            //     if (a.productType < b.productType) return -1;
            //     if (a.productType > b.productType) return 1;
            //     return 0;
            // })
            // return Object.keys(uniq);
            let set = new Set();
            let result = [];

            for (let item of this.products) {
                set.add(item.productType);
            }

            for (let item of set) {
                result.push(item);
            }
            result.sort(function(a, b) {
                if (a < b) return -1;
                if (a > b) return 1;
                return 0;
            })
            return result;
        }
        getInfo() {
            if (this.products.length === 0) {
                var result1 = {
                    products: [],
                    totalPrice: 0
                };
                // Return it
                return result1;
            }
            var result2 = {
                products: [],
                totalPrice: 0
            };
            ////////////////////////
            let set = new Set();
            let result3 = [];

            for (let item of this.products) {
                result2.totalPrice += item.price;
                set.add(item);
            }

            for (let item of set) {
                result2.products.push(item);
            }
            result2.products.sort(function(a, b) {
                if (a.name < b.name) return -1;
                if (a.name > b.name) return 1;
                return 0;
            })
            for (var index = 0; index < result2.products.length - 1; index++) {
                if (result2.products[index].name == result2.products[index + 1].name) {
                    result2.products.splice(index, 1);
                    index = 0;
                }
            }
            for (var index = 0; index < result2.products.length - 1; index++) {
                if (result2.products[index].name == result2.products[index + 1].name) {
                    result2.products.splice(index, 1);
                    index = 0;
                }
            }
            // It is fine
            return result2;
            //////////////////////
        }
    }
    return {
        Product,
        ShoppingCart
    };
}