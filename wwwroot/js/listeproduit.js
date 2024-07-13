const products = {
    ondileur: [
        { name: 'Ondileur Product 1', imageUrl: 'coffrer' },
        { name: 'Ondileur Product 2', imageUrl: 'path/to/image2.jpg' },
        { name: 'Ondileur Product 3', imageUrl: 'path/to/image3.jpg' }
    ],
    // Add other categories in similar fashion
};
function showProducts(category) {
    const productList = document.getElementById('product-list');
    productList.innerHTML = `<h2>Products in ${category.replace(/([A-Z])/g, ' $1')}</h2><div class="product-block">` +
        products[category].map(product => `
            <div>
                <img src="${product.imageUrl}" alt="${product.name}">
                <p>${product.name}</p>
            </div>
        `).join('') + '</div>';
    productList.style.display = 'block';
}
function showProducts(category) {
    const productList = document.getElementById('product-list');
    productList.innerHTML = `<h2>Products in ${category.replace(/([A-Z])/g, ' $1')}</h2><div class="product-block">` +
        products[category].map(product => `
            <div class="product-item">
                <img src="${product.imageUrl}" alt="${product.name}">
                <div class="product-info">
                    <p class="product-name">${product.name}</p>
                    <p class="product-description">${product.description}</p>
                    <button class="detail-button">Details</button>
                </div>
            </div>
        `).join('') + '</div>';
    productList.style.display = 'block';
}