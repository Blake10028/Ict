//to add tax and put result in the total text box
function add_number() {
    var first_number = parseInt(document.getElementById("TextBox1").value);
    var second_number = parseInt(document.getElementById("TextBox2").value);
    var result = second_number / 100 * first_number + first_number;

    document.getElementById("TextBox3").value = result;
}

//making the select and inputed stuff into const to work with
const from_currencyEl = document.getElementById('from_currency');
const from_ammountEl = document.getElementById('TextBox3');
const to_currencyEl = document.getElementById('to_currency');
const to_ammountEl = document.getElementById('TextBox4');
const rateEl = document.getElementById('rate');
const exchange = document.getElementById('Convert');

 
 //work out the total amount from one country $ to a different country $ e.g. usd to nzd  
function calculate() {
	const from_currency = from_currencyEl.value;
	const to_currency = to_currencyEl.value;
	
	fetch(`https://api.exchangerate-api.com/v4/latest/${from_currency}`)
		.then(res => res.json())
		.then(res => {
		const rate = res.rates[to_currency];
		rateEl.innerText = `1 ${from_currency} = ${rate} ${to_currency}`
		to_ammountEl.value = (from_ammountEl.value * rate).toFixed(2);
    })
    calculate();
}
 

//make a function that runs all function to be called when button is clicked
    function run() {
        add_number();
        calculate();
    }