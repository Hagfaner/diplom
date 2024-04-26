let sum = 0;

// Добавляем обработчик события 'input', который будет вызывать функцию updateData
document.addEventListener('DOMContentLoaded', function () {
    var inputs = document.querySelectorAll('input[type="number"]');
    inputs.forEach(function (input) {
        input.addEventListener('input', updateData);
    });
});


function updatesum() {
    sum = 0;
    var inputs = document.querySelectorAll('input[type="number"]');
    inputs.forEach(function (input) {

        var price = input.id.slice(input.id.indexOf(".") + 1);
        sum += input.value * price;
    });
    document.getElementById('showbox').textContent = "Итоговая сумма к оплате: " + sum + " руб.";
}
function updateData(id_price) {
    // Получаем элемент input по его id 

    let price = id_price.target.id.slice(id_price.target.id.indexOf(".") + 1);
    var inputElement = document.getElementById(id_price.target.id);

    // Проверяем, что значение больше или равно нулю
    if (inputElement.value < 1) {
        alert('Значение должно быть больше или равно одному.');
        inputElement.value = 1;
        // Обновляем содержимое элемента с id result
        //sum += price * inputElement.value;
        //document.getElementById('showbox').textContent = sum;

    };
    localStorage.setItem(inputElement.id, inputElement.value);
    updatesum();
}