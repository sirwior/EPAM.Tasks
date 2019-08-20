let phones = [{ratingRevievs: "264 отзыва", price: {oldUan: "4 333 грн", newUan: "3 799 грн"}, name: "Motorola MOTO G4 (XT1622) Black"},
    {ratingRevievs: "1355 отзывов", price: "4 999 грн", name: "Samsung Galaxy J7 J700H/DS Black + карта памяти 16гб + чехол + защитное стекло!"},
    {ratingRevievs: "426 отзывов", price: "5 199 грн", name: "Samsung Galaxy J5 (2016) J510H/DS Black + защитное стекло + чехол!"},
    {ratingRevievs: "403 отзыва", price: "4 349 грн", name: "Xiaomi Redmi Note 4X 3/32GB Black"},
    {ratingRevievs: "488 отзывов", price: "6 199 грн", name: "Samsung Galaxy J7 (2016) J710F/DS Gold + защитное стекло + чехол!"},
    {ratingRevievs: "198 отзывов", price: {oldUan: "3 495 грн", newUan: "2 995 грн"}, name: "Lenovo K5 (A6020a40) Silver"},
    {ratingRevievs: "352 отзыва", price: {oldUan: "9 799 грн", newUan: "7 999 грн"}, name: "Apple iPhone 5s 16GB Space Gray"},
    {ratingRevievs: "59 отзывов", price: "5 999 грн", name: "Nokia 5 Dual Sim Tempered Blue"},
    {ratingRevievs: "119 отзывов", price: "11 999 грн", name: "Samsung Galaxy A5 2017 Duos SM-A520 Black + карта памяти 128гб!"},
    {ratingRevievs: "1106 отзывов", price: "3 999 грн", name: "Samsung Galaxy J5 J500H/DS Black + чехол + защитное стекло!"},
    {ratingRevievs: "380 отзывов", price: "2 199 грн", name: "Huawei Y3 II Tiffany (White-Blue) + чехол + защитное стекло!"},
    {ratingRevievs: "86 отзывов", price: {oldUan: "24 999 грн", newUan: "22 999 грн"}, name: "Samsung Galaxy S8 64GB Midnight Black + карта памяти 64гб + оригинальный чехол!"},
    {ratingRevievs: "177 отзывов", price: "6 499 грн", name: "Huawei P8 Lite 2017 White + УМБ Huawei AP08Q + защитное стекло + чехол!"},
    {ratingRevievs: "347 отзывов", price: "4 299 грн", name: "Xiaomi Redmi 4X 3/32GB Black (Международная версия)"},
    {ratingRevievs: "709 отзывов", price: "2 799 грн", name: "Samsung Galaxy J1 2016 SM-J120H Black + защитное стекло + чехол!"},
    {ratingRevievs: "527 отзывов", price: "3 999 грн", name: "Huawei Y6 Pro Gold + чехол + защитное стекло!"},
    {ratingRevievs: "66 отзывов", price: "16 499 грн", name: "Apple iPhone 6s 32GB Gold"},
    {ratingRevievs: "14 отзывов", price: "11 499 грн", name: "Apple iPhone 6 32GB Space Gray"},
    {ratingRevievs: "70 отзывов", price: {oldUan: "7 399 грн", newUan: "5 999 грн"},name: "Asus ZenFone 2 32GB (ZE551ML) Black"},
    {ratingRevievs: "45 отзывов",price: "4 299 грн", name: "Nokia 3 Dual Sim Silver White + сертификаты 500 грн!"},
    {ratingRevievs: "376 отзывов", price: "3 899 грн", name: "Meizu M3 Note 32GB Grey (Международная версия)"},
    {ratingRevievs: "111 отзывов", price: {oldUan: "9 999 грн", newUan: "7 999 грн"}, name: "Sony Xperia X Dual (F5122) White"},
    {ratingRevievs: "40 отзывов", price: "2 222 грн", name: "Lenovo Vibe C (A2020) Black + УМБ PowerPlant 5200 mAh в подарок!"},
    {ratingRevievs: "93 отзыва", price: "18 999 грн", name: "Apple iPhone 7 32GB Black"},
    {ratingRevievs: "33 отзыва", price: "16 999 грн", name: "Huawei P10 4/32GB Black + сертификат 2500грн + чехол Huawei Smart View Cover!"},
    {ratingRevievs: "71 отзыв", price: {oldUan: "2 399 грн", newUan: "1 999 грн"}, name: "LG K5 X220ds Gold"},
    {ratingRevievs: "39 отзывов", price: "2 995 грн", name: "Lenovo C2 Power (K10a40) Black"},
    {ratingRevievs: "156 отзывов", price: "2 599 грн", name: "Nous NS 5006 Gold"},
    {ratingRevievs: "40 отзывов", price: "19 689 грн", name: "LG G6 Mystic White"},
    {ratingRevievs: "24 отзыва", price: "5 995 грн", name: "Motorola MOTO G5 (XT1676) Grey"},
    {ratingRevievs: "7 отзывов", price: {oldUan: "10 999 грн", newUan: "9 999 грн"}, name: "HTC One X10 Dual Sim Silver"},
    {ratingRevievs: "18 отзывов", price: {oldUan: "5 999 грн", newUan: "4 999 грн"}, name: "Sony Xperia L1 Dual Black"}];





let res = [];


phones.sort((left, right) =>{
    let left_price = left.price.newUan || left.price;
    let right_price = right.price.newUan || right.price;
    let left_number = getPriceNumber(left_price);
    let right_number = getPriceNumber(right_price);
    if (left_number < right_number) {
        return -1;
    }
    if ( left_number > right_number ) {
        return 1;
    }
    return 0;
});



// Работает в сафари:
 /*let sortPhones = phones.sort((left, right) => {
    let left_price = left.price.newUan || left.price;
    let right_price = right.price.newUan || right.price;
    return getPriceNumber(left_price) >= getPriceNumber(right_price);
   });
*/

function getPriceNumber(price_string) {
    return +price_string.split('г')[0].replace(/ /g, '')
   }

  //kekpuks.sort(x => x.price.newprice ? x.price.newprice : x.price)


//var container = document.getElementById("container");
let tab = document.createElement("div");
tab.className = "table";
let k = 0;

for(let j = 0; j < 8; j ++)
{
    row = document.createElement("div");
    row.className = "row";
    for (let i = 0; i < 4; i++) 
    {
        //container.innerHTML += '<div class="box"></div>';
        cell = document.createElement("div");
        cell.className = "cell";

        let name_elem = document.createElement("p");
        name_elem.className = "name";
        name_elem.innerText = phones[k].name;
        cell.appendChild(name_elem);
        

        if((phones[k].price.newUan || phones[k].price) == phones[k].price.newUan )
        {
            let new_price_elem = document.createElement("p");
            new_price_elem.className = "new_price";
            new_price_elem.innerText = phones[k].price.newUan;
            cell.appendChild(new_price_elem);

            let old_price_elem = document.createElement("p");
            old_price_elem.className = "old_price";
            old_price_elem.innerText = phones[k].price.oldUan;
            cell.appendChild(old_price_elem);
        }
        else
        {
            let price_elem = document.createElement("p");
            price_elem.className = "price";
            price_elem.innerText = phones[k].price;
            cell.appendChild(price_elem);
        }
        
        let ratting_elem = document.createElement("p");
        ratting_elem.className = "ratting";
        ratting_elem.innerText = phones[k].ratingRevievs;
        cell.appendChild(ratting_elem);
        
        row.appendChild(cell);

        k++;
    }
    tab.appendChild(row);
}

document.body.appendChild(tab);



/*for(let i = 0; i < phones.length; i++)
{
    document.querySelectorAll(div.box)[i].innerHTML = phones[i].name + " " + phones[i].ratingRevievs +"\n";

}
*/

//let div = document.createElement('div');

//div.innerHTML = res;

//document.body.append(div);


