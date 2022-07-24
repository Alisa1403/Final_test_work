# Итоговая контрольная работа

В данном проекте реализовано решение программы которая из имеющегося массива строк формирует массив строк, длина которых меньше или равна 3 символам. 

## Описание решения программы 
+ В начале кода я написала метод Print, который принимает на вход массив строк, перебирает каждый элемент массива и печетает в консоль через пробел.

+ Первоначальный массив я решила задать самостоятельно, поэтому после вышеописанного метода создаю 2 массива строк: 

    *1 - исходный массив*

    *2 - массив, в который мы будем добавлять строки с длиной меньше или равной 3 символа.*

     Длину 2 массива задала равную длине массива 1, так как мы не знаем сколько элементов у нас будут подходить под условие, однако это будет точно не больше длины изначального массива.

+ Я решила использовать __цикл с предусловием__, который начинает считать от нуля до конца первоначального массива с шагом +1.

+ Внутри цикла с предусловием добавила условие поиска строки с длиной меньшей или равной 3. 

    При единовременном выполнении двух условий программа добавляет строку в массив 2 на место в с индексом n, который изначально был равен 0 и увеличивался на 1 шаг только при выполнении двух условий. 

    Это сделано для того, чтобы элементы в массиве 2 добавлялись по порядку и не было пустых значений.

+ В завершении программы и вывода результата в терминал вызвала метод Print, который описывала ранее.