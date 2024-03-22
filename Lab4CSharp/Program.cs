// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;

/// <summary>
///  Top-level statements 
///  Код програми (оператори)  вищого рівня
/// </summary>
///
Console.WriteLine("Lab4 C# ");
AnyFunc();

/// <summary>
/// 
///  Top-level statements must precede namespace and type declarations.
/// At the top-level methods/functions can be defined and used
/// На верхньому рівні можна визначати та використовувати методи/функції
/// </summary>
void AnyFunc()
{
    Console.WriteLine(" Some function in top-level");
}
Console.WriteLine("Problems 1 ");
AnyFunc();
//  приклад класів
UserClass cl = new UserClass();
cl.Name = " UserClass top-level ";
Lab4CSharp.UserClass cl2 = new Lab4CSharp.UserClass();
cl2.Name = " UserClass namespace Lab4CSharp ";
Console.WriteLine(cl + "   " + cl2 + "   ");

 Console.Write("Enter the number of task (1 - 2): ");
            int choice = Int32.Parse(Console.ReadLine());
            switch (choice){
                case 1:{
                    Trapeze[] trapezeArray = new Trapeze[]{
                    new Trapeze(10, 6, 5, "red"),
                    new Trapeze(4, 4, 4, "yellow")
                    };

                    for (int index = 0; index < trapezeArray.Length; index++){
                        Trapeze trapeze = trapezeArray[index];
                        Console.WriteLine(trapeze);
                        Console.WriteLine("The perimeter of trapeze: " + trapeze.Perimeter());
                        Console.WriteLine("The area of trapeze: " + trapeze.Area());

                    if (trapeze.IsSquare()){
                        Console.WriteLine("This trapeze is square!");
                    }

                    Console.WriteLine("Accessing using index: ");
                    for (int i = 0; i < 4; i++){
                        Console.WriteLine($"Element at index {i}: {trapeze[i]}");
                    }

                    Console.WriteLine("Incrementing Trapeze: " + ++trapeze);
                    Console.WriteLine("Decrementing Trapeze: " + --trapeze);
                    Console.WriteLine("Multiplying Trapeze by 2: " + (trapeze * 2));

                    if (trapeze) Console.WriteLine("Trapeze is not null!");
                    else Console.WriteLine("Trapeze is null!");

                    string trapezestr = (string)trapeze;
                    Console.WriteLine("Trapeze as string: " + trapezestr);
                    Console.WriteLine();
                    }
                } break;
                case 2:{
                    Console.Write("Task 2");
                    VectorFloat vector1 = new VectorFloat(3, 1.5f);
                    VectorFloat vector2 = new VectorFloat(3, 2.5f);

        // Виведення значень векторів
        Console.WriteLine("\nVector 1:");
        vector1.Output();
        Console.WriteLine("\nVector 2:");
        vector2.Output();

        // Перевірка операцій порівняння
        Console.WriteLine("\nVector 1 == Vector 2: " + (vector1 == vector2));
        Console.WriteLine("Vector 1 != Vector 2: " + (vector1 != vector2));
        Console.WriteLine("Vector 1 > Vector 2: " + (vector1 > vector2));
        Console.WriteLine("Vector 1 >= Vector 2: " + (vector1 >= vector2));
        Console.WriteLine("Vector 1 < Vector 2: " + (vector1 < vector2));
        Console.WriteLine("Vector 1 <= Vector 2: " + (vector1 <= vector2));

        // Перевірка арифметичних операцій
        Console.WriteLine("\nVector 1 + Vector 2:");
        (vector1 + vector2).Output();
        Console.WriteLine("\nVector 1 - Vector 2:");
        (vector1 - vector2).Output();
        Console.WriteLine("\nVector 1 * Vector 2:");
        (vector1 * vector2).Output();
        Console.WriteLine("\nVector 1 / Vector 2:");
        (vector1 / vector2).Output();
        Console.WriteLine("\nVector 1 % Vector 2:");
        (vector1 % vector2).Output();

        // Перевірка побітових операцій
        Console.WriteLine("\nVector 1 | Vector 2:");
        (vector1 | vector2).Output();
        Console.WriteLine("\nVector 1 ^ Vector 2:");
        (vector1 ^ vector2).Output();
        Console.WriteLine("\nVector 1 & Vector 2:");
        (vector1 & vector2).Output();

        // Перевірка зсувів
        Console.WriteLine("\nVector 1 >> Vector 2:");
        (vector1 >> vector2).Output();
        Console.WriteLine("\nVector 1 << Vector 2:");
        (vector1 << vector2).Output();

        // Інші операції
        Console.WriteLine("\n~Vector 1:");
        (~vector1).Output();
        Console.WriteLine("\n++Vector 1:");
        (++vector1).Output();
        Console.WriteLine("\n--Vector 1:");
        (--vector1).Output();
        Console.WriteLine("\n!Vector 1: " + !vector1);
                }break;
            }


class UserClass
{
    public string Name { get; set; }
}

/// Трапеція
class Trapeze
{
    private int a, b, h;
    private string c;
    public Trapeze(int a, int b, int h, string c)
    {
        this.a = a;
        this.b = b;
        this.h = h;
        this.c = c;
    }

    public double Perimeter()
    {
        double rez = a + b + 2 * Math.Sqrt(Math.Pow(h, 2) + Math.Pow((b - a) / 2.0, 2));
        return Math.Round(rez, 2);
    }

    public double Area()
    {
        double rez = (a + b) * h / 2.0;
        return Math.Round(rez, 2);
    }

    public bool IsSquare()
    {
        return a == b && a == h;
    }

    public int A
    {
        get { return a; }
        set { a = value; }
    }

    public int B
    {
        get { return b; }
        set { b = value; }
    }

    public int H
    {
        get { return h; }
        set { h = value; }
    }

    public string C
    {
        get { return c; }
    }

    public static Trapeze operator++(Trapeze trapeze){
        trapeze.a++;
        trapeze.b++;
        return trapeze;
    }

    public static Trapeze operator--(Trapeze trapeze){
        trapeze.a--;
        trapeze.b--;
        return trapeze;
    }

    public static Trapeze operator*(Trapeze trapeze, int scalar){
        trapeze.a *= scalar;
        trapeze.b *= scalar;
        return trapeze;
    }

    public static bool operator true(Trapeze trapeze){
        return trapeze != null;
    }

    public static bool operator false(Trapeze trapeze){
        return trapeze == null;
    }

    public object this[int index]{
        get{
            switch(index){
                case 0: return a;
                case 1: return b;
                case 2: return h;
                case 3: return c;
                default: throw new IndexOutOfRangeException("Invalid index!");
            }
        }
        set{
            switch(index){
                case 0: a = (int)value; break;
                case 1: b = (int)value; break;
                case 2: h = (int)value; break;
                case 3: c = (string)value; break;
                default: throw new IndexOutOfRangeException("Invalid index!");
            }
        }
    }

    public static explicit operator string(Trapeze trapeze){
        return $"Trapeze: side a = {trapeze.a}, side b = {trapeze.b}, height = {trapeze.h}, color = {trapeze.c}";
    }

    public static explicit operator Trapeze(string str){
    string[] parts = str.Split(new char[] { '=', ',', ':' }, StringSplitOptions.RemoveEmptyEntries);
    if (parts.Length == 8 && parts[0] == "Trapeze")
    {
        int a, b, h;
        if (int.TryParse(parts[1], out a) && int.TryParse(parts[3], out b) && int.TryParse(parts[5], out h))
        {
            return new Trapeze(a, b, h, parts[7]);
        }
    }
    throw new ArgumentException("Invalid string format for Trapeze.");
    }

        public override string ToString()
    {
        return $"Trapeze: side a={a}, side b={b}, height={h}, color={c}";
    }
}

//Завдання 2
class VectorFloat{
    //Поля
    protected float[] FArray;
    protected uint num;
    protected int codeError;
    protected static uint num_vec;

    //Конструктори
    public VectorFloat(){
        num = 1;
        FArray = new float[num];
        codeError = 0;
        num_vec++;
    }

    public VectorFloat(uint size){
        num = size;
        FArray = new float[num];
        codeError = 0;
        num_vec++;
    }

    public VectorFloat(uint size, float initvalue){
        num = size;
        FArray = new float[num];
        for (uint i = 0; i < num; i++){
            FArray[i] = initvalue;
        }
        codeError = 0;
        num_vec++;
    }

    //Деструктор
    ~VectorFloat(){
        Console.WriteLine("Destructor called!");
    }

    //Методи
    public void Input(){
        for (uint i = 0; i < num; i++){
            Console.Write($"Element {i}: ");
            FArray[i] = float.Parse(Console.ReadLine());
        }
    }

    public void Output(){
        for (uint i = 0; i < num; i++){
            Console.WriteLine($"Element {i}: {FArray[i]}");
        }
    }

    public void SetValue(float value){
        for (uint i = 0; i < num; i++){
            FArray[i] = value;
        }
    }

    public static uint CalculateVectors(){
        return num_vec;
    }

    //Властивості
    public uint Size{
        get {return num;}
    }

    public int codeErr{
        get {return codeError;}
        set {codeError = value;}
    }

    //Індексатор
    public float this[int index]{
        get{
            if (index < 0 || index >= num){
                codeError = -1;
                return 0;
            } else{
                codeError = 0;
                return FArray[index];
            }
        }
        set{
            if (index < 0 || index >= num){
                codeError = -1;
            } else{
                codeError = 0;
                FArray[index] = value;
            }
        }
    }

    //Перевантаження
    public static VectorFloat operator ++(VectorFloat vector){
        for (uint i = 0; i < vector.num; i++){
            vector.FArray[i]++;
        }
        return vector;
    }

    public static VectorFloat operator --(VectorFloat vector){
        for (uint i = 0; i < vector.num; i++){
            vector.FArray[i]--;
        }
        return vector;
    }

    public static bool operator true(VectorFloat vector){
        foreach (float elem in vector.FArray){
            if (elem == 0){
                return false;
            }
        }
        return true;
    }

    public static bool operator false(VectorFloat vector){
        foreach (float elem in vector.FArray){
            if (elem == 0){
                return true;
            }
        }
        return false;
    }

    public static bool operator !(VectorFloat vector){
         for (uint i = 0; i < vector.num; i++){
            if (vector.FArray[i] == 0){
                return false;
            }
        }
        return vector.num != 0;
    }


    public static VectorFloat operator ~(VectorFloat vector){
        VectorFloat rez = new VectorFloat(vector.num);
        for (int i = 0; i < vector.num; i++){
            rez[i] = ~Convert.ToInt32(vector[i]);
        }
        return rez;
    }

    //Арифметичні бінарні операції
    public static VectorFloat operator +(VectorFloat vector1, VectorFloat vector2){
        if (vector1.num != vector2.num){
            throw new ArgumentException("Vectors must be the same length!");
        }
        VectorFloat rez = new VectorFloat(vector1.num);
        for (int i = 0; i < vector1.num; i++){
            rez.FArray[i] = vector1.FArray[i] + vector2.FArray[i];
        }
        return rez;
    }

    public static VectorFloat operator +(VectorFloat vector1, float scalar){
        VectorFloat rez = new VectorFloat(vector1.num);
        for (int i = 0; i < vector1.num; i++){
            rez.FArray[i] = vector1.FArray[i] + scalar;
        }
        return rez;
    }

    public static VectorFloat operator -(VectorFloat vector1, VectorFloat vector2){
        if (vector1.num != vector2.num){
            throw new ArgumentException("Vectors must be the same length!");
        }
        VectorFloat rez = new VectorFloat(vector1.num);
        for (int i = 0; i < vector1.num; i++){
            rez.FArray[i] = vector1.FArray[i] - vector2.FArray[i];
        }
        return rez;
    }

    public static VectorFloat operator -(VectorFloat vector1, float scalar){
        VectorFloat rez = new VectorFloat(vector1.num);
        for (int i = 0; i < vector1.num; i++){
            rez.FArray[i] = vector1.FArray[i] - scalar;
        }
        return rez;
    }

    public static VectorFloat operator *(VectorFloat vector1, VectorFloat vector2){
        if (vector1.num != vector2.num){
            throw new ArgumentException("Vectors must be the same length!");
        }
        VectorFloat rez = new VectorFloat(vector1.num);
        for (int i = 0; i < vector1.num; i++){
            rez.FArray[i] = vector1.FArray[i] * vector2.FArray[i];
        }
        return rez;
    }

    public static VectorFloat operator *(VectorFloat vector1, float scalar){
        VectorFloat rez = new VectorFloat(vector1.num);
        for (int i = 0; i < vector1.num; i++){
            rez.FArray[i] = vector1.FArray[i] * scalar;
        }
        return rez;
    }

    public static VectorFloat operator /(VectorFloat vector1, VectorFloat vector2){
        if (vector1.num != vector2.num){
            throw new ArgumentException("Vectors must be the same length!");
        }
        VectorFloat rez = new VectorFloat(vector1.num);
        for (int i = 0; i < vector1.num; i++){
            if (vector2.FArray[i] == 0){
                throw new DivideByZeroException("Division by zero!");
            }
            rez.FArray[i] = vector1.FArray[i] / vector2.FArray[i];
        }
        return rez;
    }

    public static VectorFloat operator /(VectorFloat vector1, float scalar){
        if (scalar == 0){
            throw new DivideByZeroException("Division by zero!");
        }
        VectorFloat rez = new VectorFloat(vector1.num);
        for (int i = 0; i < vector1.num; i++){
            rez.FArray[i] = vector1.FArray[i] / scalar;
        }
        return rez;
    }

    public static VectorFloat operator %(VectorFloat vector1, VectorFloat vector2){
        if (vector1.num != vector2.num){
            throw new ArgumentException("Vectors must be the same length!");
        }
        VectorFloat rez = new VectorFloat(vector1.num);
        for (int i = 0; i < vector1.num; i++){
            if (vector2.FArray[i] == 0){
                throw new DivideByZeroException("Division by zero!");
            }
            rez.FArray[i] = vector1.FArray[i] % vector2.FArray[i];
        }
        return rez;
    }

    //Побітові бінарні операції
    public static VectorFloat operator |(VectorFloat vector1, VectorFloat vector2){
        if (vector1.num != vector2.num){
            throw new ArgumentException("Vectors must be the same length!");
        }
        VectorFloat rez = new VectorFloat(vector1.num);
        for (int i = 0; i < vector1.num; i++){
            rez.FArray[i] = (byte)vector1.FArray[i] | (byte)vector2.FArray[i];
        }
        return rez;
    }

    public static VectorFloat operator |(VectorFloat vector, byte scalar){
    VectorFloat rez = new VectorFloat(vector.num);
    for (int i = 0; i < vector.num; i++){
        rez.FArray[i] = (byte)vector.FArray[i] | scalar;
    }
    return rez;
    }

    public static VectorFloat operator ^(VectorFloat vector1, VectorFloat vector2){
        if (vector1.num != vector2.num){
            throw new ArgumentException("Vectors must be the same length!");
        }
        VectorFloat rez = new VectorFloat(vector1.num);
        for (int i = 0; i < vector1.num; i++){
            rez.FArray[i] = (byte)vector1.FArray[i] ^ (byte)vector2.FArray[i];
        }
        return rez;
    }

    public static VectorFloat operator ^(VectorFloat vector, byte scalar){
    VectorFloat rez = new VectorFloat(vector.num);
    for (int i = 0; i < vector.num; i++){
        rez.FArray[i] = (byte)vector.FArray[i] ^ scalar;
    }
    return rez;
    }

    public static VectorFloat operator &(VectorFloat vector1, VectorFloat vector2){
        if (vector1.num != vector2.num){
            throw new ArgumentException("Vectors must be the same length!");
        }
        VectorFloat rez = new VectorFloat(vector1.num);
        for (int i = 0; i < vector1.num; i++){
            rez.FArray[i] = (byte)vector1.FArray[i] & (byte)vector2.FArray[i];
        }
        return rez;
    }

    public static VectorFloat operator &(VectorFloat vector, byte scalar){
    VectorFloat rez = new VectorFloat(vector.num);
    for (int i = 0; i < vector.num; i++){
        rez.FArray[i] = (byte)vector.FArray[i] & scalar;
    }
    return rez;
    }

    public static VectorFloat operator >>(VectorFloat vector1, VectorFloat vector2){
        if (vector1.num != vector2.num){
            throw new ArgumentException("Vectors must be the same length!");
        }
        VectorFloat rez = new VectorFloat(vector1.num);
        for (int i = 0; i < vector1.num; i++){
            rez.FArray[i] = (byte)vector1.FArray[i] >> (byte)vector2.FArray[i];
        }
        return rez;
    }

    public static VectorFloat operator >>(VectorFloat vector, uint scalar){
    VectorFloat rez = new VectorFloat(vector.num);
    for (int i = 0; i < vector.num; i++){
        rez.FArray[i] = (byte)vector.FArray[i] >> (int)scalar;
    }
    return rez;
    }

    public static VectorFloat operator <<(VectorFloat vector1, VectorFloat vector2){
        if (vector1.num != vector2.num){
            throw new ArgumentException("Vectors must be the same length!");
        }
        VectorFloat rez = new VectorFloat(vector1.num);
        for (int i = 0; i < vector1.num; i++){
            rez.FArray[i] = (byte)vector1.FArray[i] << (byte)vector2.FArray[i];
        }
        return rez;
    }

    public static VectorFloat operator <<(VectorFloat vector, uint scalar){
    VectorFloat rez = new VectorFloat(vector.num);
    for (int i = 0; i < vector.num; i++){
        rez.FArray[i] = (byte)vector.FArray[i] << (int)scalar;
    }
    return rez;
    }

    public static bool operator ==(VectorFloat vector1, VectorFloat vector2){
        if (vector1.num != vector2.num){
            return false;
        }
        for (int i = 0; i < vector1.num; i++){
            if (vector1.FArray[i] != vector2.FArray[i]){
                return false;
            }
        }
        return true;
    }

    public static bool operator !=(VectorFloat vector1, VectorFloat vector2){
        return !(vector1 == vector2);
    }

    public static bool operator >(VectorFloat vector1, VectorFloat vector2){
        if (vector1.num != vector2.num){
            throw new ArgumentException("Vectors must be the same length!");
        }
        for (int i = 0; i < vector1.num; i++){
            if (vector1.FArray[i] <= vector2.FArray[i]){
                return false;
            }
        }
        return true;
    }

    public static bool operator <(VectorFloat vector1, VectorFloat vector2){
         if (vector1.num != vector2.num){
            throw new ArgumentException("Vectors must be the same length!");
        }
        for (int i = 0; i < vector1.num; i++){
            if (vector1.FArray[i] >= vector2.FArray[i]){
                return false;
            }
        }
        return true;
    }

    public static bool operator >=(VectorFloat vector1, VectorFloat vector2){
        if (vector1.num != vector2.num){
            throw new ArgumentException("Vectors must be the same length!");
        }
        for (int i = 0; i < vector1.num; i++){
            if (vector1.FArray[i] < vector2.FArray[i]){
                return false;
            }
        }
        return true;
    }

    public static bool operator <=(VectorFloat vector1, VectorFloat vector2){
        if (vector1.num != vector2.num){
            throw new ArgumentException("Vectors must be the same length!");
        }
        for (int i = 0; i < vector1.num; i++){
            if (vector1.FArray[i] > vector2.FArray[i]){
                return false;
            }
        }
        return true;
    }



}