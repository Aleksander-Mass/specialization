# Выбор специализации
## Урок 2. Итоги блока. Выбор специализации
## Практическое задание
# Контрольная работа
Необходимо:
1.Создать репозиторий на GitHub
2.Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете ее в отдельный метод)
3.Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4.Написать программу, решающую поставленную задачу
5.Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что все залито одним коммитом, как минимум этапы два, три и четыре должны быть расположены в разных коммитах).

## Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуру, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:

[“hello”, “2”, “world”, “:-)”] -> [“2”, «:-)«]

[“1234”, “1567”, “-2”, “computer science”] -> [“-2”]

[“Russia”, “Denmark”, “Kazan”] -> []

## Описание решения
- задается массив строк arr = []
- вводится переменная i = 0 для определения количества строк в заданном массиве
- вводится переменная j = 0 для определения количества символов в строке
- вводится переменная n = 4 для того, чтобы выбрать строки длина которых меньше либо равна 3 символам
- логичекий блок i < len позволяет перебрать все строки в заданном массиве, где переменная len равна длине заданного массива
- далее логический блок length(arr[i]) < n выбирает элементы массива, количество символов в которых меньше либо равно 3
- отобранные элементы массива, у которых количество символов меньше либо равно 3 формируют новый массив
res[j] = arr[i]