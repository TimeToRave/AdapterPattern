# Реализация паттерна "Адаптер"

[![Tests](https://github.com/TimeToRave/AdapterPattern/actions/workflows/Unit%20testing.yml/badge.svg)](https://github.com/TimeToRave/AdapterPattern/actions/workflows/Unit%20testing.yml)

## Цель

Реализовать две независимых программы:
 1. Программа, которая читает данные о двух матрицах А и В из файла F0, складывает матрицы и сохраняет результат А+В в другой файл F1
 2. Программа, которая может генерить данные матриц А и В и писать их в файл с именем F2.
 
Реализовать адаптер для второй программы, для вызова первой программы для того, чтобы программа могла суммировать сгенерированные матрицы

## Диаграмма классов

![Диаграмма классов](https://raw.githubusercontent.com/TimeToRave/AdapterPattern/main/ClassDiagram.png)
