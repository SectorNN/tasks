# Итоговая работа

## В данном разделе выполнена итоговая контрольная работа.
1. Заведён репозиторий на GitHub
1. Составлен алгоритм
1. Написан код программы  

Блок-схема программы:  

![Блок-схема](https://online.habarskoe.ru/bs.jpg)  

## Описание решения  

Программа состоит из основной (FilterArr) и вспомогательной (PopArrElement) функции.  

**Основная функция:**  
Проходит по элементам массива циклом "for"; если находит подходящий под условия элемент (строка > 3 символа) вызывает вспомогательную функцию.  

**Вспомогательная функция (PopArrElement):**  
Принимает массив по ссылке и номер индекса. Создаёт новвый массив, не содержащий этот номер индекса. В конце работы заменяет исходный массив вновь созданным, тем самым выполняет функцию удаления заданного элемента массива.