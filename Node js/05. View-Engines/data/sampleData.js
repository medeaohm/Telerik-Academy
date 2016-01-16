'use strict';

var smartPhones = [
    {
        brand: 'Samsung',
        model: 'S3',
        price: '225',
        image: 'http://drop.ndtv.com/TECH/product_database/images/442014103050AM_635_samsung_galaxy_s3_neo.jpeg'
    }, 
    {
        brand: 'Apple',
        model: 'Iphone 5S',
        price: '2800',
        image: 'http://www.imore.com/sites/imore.com/files/styles/large/public/field/image/2014/03/topic_iphone_5.png?itok=EHmSheG0'
    },
    {
        brand: 'Nokia',
        model: 'Lumia 730',
        price: '400',
        image: 'http://phabletkart.com/wp-content/uploads/2015/03/nikia-lumia-730.jpg'
    }, 
    {
        brand: 'LG',
        model: 'Magna',
        price: '330',
        image: 'http://4.bp.blogspot.com/-ZF34BYnKJAM/VUxHJcX3baI/AAAAAAAALrw/kGB4i7Xv1y8/s640/LG-Magna.jpg'
    }
]; 

var tablets = [
    {
        brand: 'Samsung',
        model: 'Tab 4',
        price: '880',
        image: 'http://ecx.images-amazon.com/images/I/81n-vugKcTL._SL1500_.jpg'
    }, 
    {
        brand: 'Apple',
        model: 'Ipad Air2',
        price: '3500',
        image: 'http://ipadwiki.com/wp-content/uploads/2015/06/apple-ipad-air-2-A1566-Wi-Fi-Cellular-2nd-Generation-3.jpg'
    },
    {
        brand: 'Nokia',
        model: 'N1',
        price: '600',
        image: 'http://www.bgr.in/wp-content/uploads/2014/11/jolla-tablet-announced.jpg'
    }, 
    {
        brand: 'LG',
        model: 'G-Pad',
        price: '530',
        image: 'http://browsingphones.com/wp-content/uploads/2015/06/LG-Tablet-Price-In-Nigeria-G-Pad-Specs-Jumia-Konga5.jpg'
    }
];

var wearables = [
    {
        brand: 'Samsung',
        model: 'Galaxy Fit',
        price: '1880',
        image: 'http://www.theinquirer.net/IMG/268/283268/samsung-galaxy-fit-540x334.png?1444686950'
    }, 
    {
        brand: 'Apple',
        model: 'HealthKit',
        price: '2500',
        image: 'http://static3.businessinsider.com/image/53e133a469bedd02492f9ede/more-evidence-that-apple-could-be-working-on-its-first-wearable-device.jpg'
    },
    {
        brand: 'Nokia',
        model: '888',
        price: '2600',
        image: 'http://limcorp.net/images/2009/5-wearable-electronic-phones/nokia-888-mobile-phone-01.jpg'
    }, 
    {
        brand: 'LG',
        model: 'Uncrate',
        price: '1200',
        image: 'http://uncrate.com/p/2014/03/lg-g-watch-2.jpg'
    }
];
    
var baseUrl = 'http://localhost:3333/';

module.exports = {
    smartPhones: smartPhones,
    tablets: tablets,
    wearables: wearables,
    links: [
        {
            title: 'Home',
            url: baseUrl + 'home'
        },
        {
            title: 'Smart Phones',
            url: baseUrl + 'smartPhones'
        },
        {
            title: 'Tablets',
            url: baseUrl + 'tablets'
        },
        {
            title: 'Wearables',
            url: baseUrl + 'wearables'
        },
    ]
}