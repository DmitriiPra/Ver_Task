## Итоговая проверочеая работа

    По заданию требуется написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равно 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

    *Примеры:*
    *["hello", "2", "world", ":-)"] --> ["2", ".-)"]*
    *["1234", "1567", "-2", "computer science"] --> ["-2"]*
    *['Russia", "Denmark", "Kazan"] --> []*


## Решение
Решение предлагается реализовать с помощью 3х методов:

1. __*Метод ArrCount*__ - путем перебора элементов заданного массива строк, находит и возвращает переменную типа int, определяющую размер нового массива для строк, попадающих под условие: длина которых меньше или равно 3 символа.

2. __*Метод СreatureSelectArray*__ - путем перебора элементов заданного массива строк, наполняет новый массив строками, попадающими под условие: длина строки меньше или равно 3 символа.

3. __*Метод PrintArray*__ - выводит в консоль результат в формате, указанном в условии задачи.

The end