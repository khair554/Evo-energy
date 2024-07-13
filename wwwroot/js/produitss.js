let currentIndex = 0;

function moveCarousel(direction) {
    const carouselInner = document.querySelector('.carousel-inner');
    const productWidth = document.querySelector('.product').clientWidth;
    const totalProducts = document.querySelectorAll('.product').length;
    const visibleProducts = Math.floor(carouselInner.clientWidth / productWidth);

    currentIndex += direction;
    if (currentIndex < 0) {
        currentIndex = 0;
    } else if (currentIndex > totalProducts - visibleProducts) {
        currentIndex = totalProducts - visibleProducts;
    }

    const offset = -currentIndex * productWidth;
    carouselInner.style.transform = `translateX(${offset}px)`;
}