# Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
# Решение задачи:
Метод StringArray3Symol принимает на вход любой массив строк.
В начале работы метод считает количество элементов с длинной строки три и менее символов, сохраняет значение count.
Затем создает пустой массив строк count длинной.
В завершении метод вновь проходит по каждоиму элементу изначального массива и если элемент три и менее сивола - добавляет его в новый массив. 