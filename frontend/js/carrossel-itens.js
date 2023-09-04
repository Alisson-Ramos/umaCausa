const swiperCampanhasProximas = new Swiper('#campanhasProximas',{
  slidesPerView: 3,
  // Optional parameters
  direction: 'horizontal',
  

  spaceBetween: 103,
  // If we need pagination
  // Navigation arrows
  navigation: {
    nextEl: '.swiper-button-next',
    prevEl: '.swiper-button-prev',
  },
});

const swiperCampanhasAcabando = new Swiper('#campanhasAcabando',{
  slidesPerView: 3,
  // Optional parameters
  direction: 'horizontal',

  spaceBetween: 103,
  // If we need pagination
  // Navigation arrows
  navigation: {
    nextEl: '.swiper-button-next',
    prevEl: '.swiper-button-prev',
  },
});

const swiperCampanhasAtuais= new Swiper('#campanhasAtuais',{
  slidesPerView: 2,
  // Optional parameters
  direction: 'horizontal',

  spaceBetween: 50,
  // If we need pagination
  // Navigation arrows
  navigation: {
    nextEl: '.swiper-button-next',
    prevEl: '.swiper-button-prev',
  },
});


const swiperOngs = new Swiper('#ongs',{
  slidesPerView: 6,
  // Optional parameters
  direction: 'horizontal',

  spaceBetween: 39,
  // If we need pagination
  // Navigation arrows
  navigation: {
    nextEl: '.swiper-button-next',
    prevEl: '.swiper-button-prev',
  },
});
