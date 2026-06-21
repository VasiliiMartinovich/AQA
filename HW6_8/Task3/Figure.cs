namespace HW6_8.Task3;
/*Написать иерархию классов «Фигуры».
Фигура -> Треугольник -> Прямоугольник -> Круг.
    Реализовать ф-ю подсчета площади для каждого типа фигуры и подсчет
периметра.
    Создать массив из 5 фигур.
    Вывести на экран сумму периметра всех фигур в массиве.*/
    
public abstract class Figure
{
    public abstract double Area();
    public abstract string Name { get; }
    public abstract double Perimeter();
}