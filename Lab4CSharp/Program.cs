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

 Console.Write("Enter the number of task (1 - 3): ");
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

                    // Операції зі скаляром
                    float scalar = 2.0f;
                    Console.WriteLine($"\nVector 1 + Scalar ({scalar}):");
                    (vector1 + scalar).Output();
                    Console.WriteLine($"\nVector 1 - Scalar ({scalar}):");
                    (vector1 - scalar).Output();
                    Console.WriteLine($"\nVector 1 * Scalar ({scalar}):");
                    (vector1 * scalar).Output();
                    Console.WriteLine($"\nVector 1 / Scalar ({scalar}):");
                    (vector1 / scalar).Output();

                    // Інші операції
                    Console.WriteLine("\n~Vector 1:");
                    (~vector1).Output();
                    Console.WriteLine("\n++Vector 1:");
                    (++vector1).Output();
                    Console.WriteLine("\n--Vector 1:");
                    (--vector1).Output();
                    Console.WriteLine("\n!Vector 1: " + !vector1);
                }break;
                case 3:{
                    FloatMatrix matrix1 = new FloatMatrix(2, 2, 1.5f);
                    FloatMatrix matrix2 = new FloatMatrix(2, 2, 2.5f);
                    float scalar = 2.0f;

                    Console.WriteLine("Matrix 1:");
                    matrix1.Output();
                    Console.WriteLine("\nMatrix 2:");
                    matrix2.Output();
                    Console.WriteLine($"\nScalar: {scalar}");

                    // Перевірка операцій між матрицями
                    Console.WriteLine("\nMatrix Operations:");

                    Console.WriteLine("\nAddition:");
                    FloatMatrix addResult = matrix1 + matrix2;
                    addResult.Output();

                    Console.WriteLine("\nSubtraction:");
                    FloatMatrix subResult = matrix1 - matrix2;
                    subResult.Output();

                    Console.WriteLine("\nMultiplication:");
                    FloatMatrix mulResult = matrix1 * matrix2;
                    mulResult.Output();

                    Console.WriteLine("\nDivision:");
                    FloatMatrix divResult = matrix1 / matrix2;
                    divResult.Output();

                    Console.WriteLine("\nModulus:");
                    FloatMatrix modResult = matrix1 % matrix2;
                    modResult.Output();

                    Console.WriteLine("\nAddition with Scalar:");
                    FloatMatrix addResultScalar = matrix1 + scalar;
                    addResultScalar.Output();

                    Console.WriteLine("\nMultiplication with Scalar:");
                    FloatMatrix mulResultScalar = matrix2 * scalar;
                    mulResultScalar.Output();

                    // Перевірка побітових операцій
                    Console.WriteLine("\nBitwise Operations:");
                    FloatMatrix orResult = matrix1 | matrix2;
                    Console.WriteLine("\nResult of Bitwise OR:");
                    orResult.Output();

                    FloatMatrix xorResult = matrix1 ^ matrix2;
                    Console.WriteLine("\nResult of Bitwise XOR:");
                    xorResult.Output();

                    FloatMatrix andResult = matrix1 & matrix2;
                    Console.WriteLine("\nResult of Bitwise AND:");
                    andResult.Output();

                    // Перевірка функцій-операцій порівняння та рівності
                    Console.WriteLine("\nEquality and Comparison:");
                    bool areEqual = matrix1 == matrix2;
                    bool greaterThan = matrix1 > matrix2;
                    bool lessThan = matrix1 < matrix2;
                    bool greaterThanOrEqual = matrix1 >= matrix2;
                    bool lessThanOrEqual = matrix1 <= matrix2;

                    Console.WriteLine($"Matrix 1 is equal to Matrix 2: {areEqual}");
                    Console.WriteLine($"Matrix 1 is greater than Matrix 2: {greaterThan}");
                    Console.WriteLine($"Matrix 1 is less than Matrix 2: {lessThan}");
                    Console.WriteLine($"Matrix 1 is greater than or equal to Matrix 2: {greaterThanOrEqual}");
                    Console.WriteLine($"Matrix 1 is less than or equal to Matrix 2: {lessThanOrEqual}");

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

//Вектор
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

//Матриця
class FloatMatrix
{
    protected float[,] FMArray;
    protected uint n, m;
    protected int codeError;
    protected static int num_mf;

    //Конструктори
    public FloatMatrix(){
        n = m = 1;
        FMArray = new float[1, 1];
        codeError = 0;
        num_mf++;
    }

    public FloatMatrix(uint rows, uint columns){
        n = rows;
        m = columns;
        FMArray = new float[rows, columns];
        codeError = 0;
        num_mf++;
    }

    public FloatMatrix(uint rows, uint columns, float initValue){
        n = rows;
        m = columns;
        FMArray = new float[rows, columns];
        for (uint i = 0; i < n; i++){
            for (uint j = 0; j < m; j++){
                FMArray[i, j] = initValue;
            }
        }
        codeError = 0;
        num_mf++;
    }

    //Деструктор
    ~FloatMatrix(){
        Console.WriteLine("Destructor called!");
    }

    //Методи
    public void Input(){
        for (uint i = 0; i < n; i++){
            for (uint j = 0; j < m; j++){
                Console.Write($"Element [{i},{j}]: ");
                FMArray[i, j] = float.Parse(Console.ReadLine());
            }
        }
    }

    public void Output(){
        for (uint i = 0; i < n; i++){
            for (uint j = 0; j < m; j++){
                Console.Write($"{FMArray[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    public void SetValue(float value){
        for (uint i = 0; i < n; i++){
            for (uint j = 0; j < m; j++){
                FMArray[i, j] = value;
            }
        }
    }

    public static int CalculateMatrices(){
        return num_mf;
    }

    //Властивості
    public uint Rows{
        get { return n; }
    }

    public uint Columns{
        get { return m; }
    }

    public int CodeError{
        get { return codeError; }
        set { codeError = value; }
    }

    //Індексатори
    public float this[int i, int j]{
        get{
            if (i < 0 || i >= n || j < 0 || j >= m){
                codeError = -1;
                return 0;
            } else{
                codeError = 0;
                return FMArray[i, j];
            }
        } set{
            if (i < 0 || i >= n || j < 0 || j >= m){
                codeError = -1;
            } else{
                codeError = 0;
                FMArray[i, j] = value;
            }
        }
    }

    public float this[int k]{
        get{
            int i = k / (int)m;
            int j = k % (int)m;
            if (i < 0 || i >= n || j < 0 || j >= m){
                codeError = -1;
                return 0;
            } else{
                codeError = 0;
                return FMArray[i, j];
            }
        } set{
            int i = k / (int)m;
            int j = k % (int)m;
            if (i < 0 || i >= n || j < 0 || j >= m){
                codeError = -1;
            } else{
                codeError = 0;
                FMArray[i, j] = value;
            }
        }
    }

    //Перевантаження
    public static FloatMatrix operator ++(FloatMatrix matrix){
        for (uint i = 0; i < matrix.n; i++){
            for (uint j = 0; j < matrix.m; j++){
                matrix.FMArray[i, j]++;
            }
        }
        return matrix;
    }

    public static FloatMatrix operator --(FloatMatrix matrix){
        for (uint i = 0; i < matrix.n; i++){
            for (uint j = 0; j < matrix.m; j++){
                matrix.FMArray[i, j]--;
            }
        }
        return matrix;
    }

    public static bool operator true(FloatMatrix matrix){
        foreach (var element in matrix.FMArray){
            if (element == 0){
                return false;
            }
        }
        return true;
    }

    public static bool operator false(FloatMatrix matrix){
        foreach (var element in matrix.FMArray){
            if (element == 0){
                return true;
            }
        }
        return false;
    }

    public static bool operator !(FloatMatrix matrix){
        foreach (var element in matrix.FMArray){
            if (element == 0){
                return false;
            }
        }
        return true;
    }

    public static FloatMatrix operator ~(FloatMatrix matrix){
        FloatMatrix rez = new FloatMatrix(matrix.n, matrix.m);
        for (int i = 0; i < matrix.n; i++){
            for (int j = 0; j < matrix.m; j++){
                rez[i, j] = ~(byte)matrix[i, j];
            }
        }
        return rez;
    }

    //Арифметичні бінарні операції
    public static FloatMatrix operator +(FloatMatrix matrix1, FloatMatrix matrix2)
    {
        uint rows = Math.Min(matrix1.n, matrix2.n);
        uint columns = Math.Min(matrix1.m, matrix2.m);
        FloatMatrix result = new FloatMatrix(rows, columns);
        for (int i = 0; i < rows; i++){
            for (int j = 0; j < columns; j++){
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        return result;
    }

    public static FloatMatrix operator +(FloatMatrix matrix, float scalar){
        FloatMatrix result = new FloatMatrix(matrix.n, matrix.m);
        for (int i = 0; i < matrix.n; i++){
            for (int j = 0; j < matrix.m; j++){
                result[i, j] = matrix[i, j] + scalar;
            }
        }
        return result;
    }

    public static FloatMatrix operator -(FloatMatrix matrix1, FloatMatrix matrix2){
        if (matrix1.n != matrix2.n || matrix1.m != matrix2.m){
            throw new ArgumentException("Matrices must have the same dimensions.");
        }
        FloatMatrix result = new FloatMatrix(matrix1.n, matrix1.m);
        for (int i = 0; i < matrix1.n; i++){
            for (int j = 0; j < matrix1.m; j++){
                result[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }
        return result;
    }

    public static FloatMatrix operator -(FloatMatrix matrix, float scalar){
        FloatMatrix result = new FloatMatrix(matrix.n, matrix.m);
        for (int i = 0; i < matrix.n; i++){
            for (int j = 0; j < matrix.m; j++){
                result[i, j] = matrix[i, j] - scalar;
            }
        }
        return result;
    }

    public static FloatMatrix operator *(FloatMatrix matrix1, FloatMatrix matrix2){
        if (matrix1.m != matrix2.n){
            throw new ArgumentException("Number of columns in the first matrix must be equal to the number of rows in the second matrix.");
        }
        FloatMatrix result = new FloatMatrix(matrix1.n, matrix2.m);
        for (int i = 0; i < matrix1.n; i++){
            for (int j = 0; j < matrix2.m; j++){
                for (int k = 0; k < matrix1.m; k++){
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        return result;
    }

    public static FloatMatrix operator *(FloatMatrix matrix, VectorFloat vector){
        if (matrix.m != vector.Size){
            throw new ArgumentException("Number of columns in the matrix must be equal to the size of the vector.");
        }
        FloatMatrix result = new FloatMatrix(matrix.n, 1);
        for (int i = 0; i < matrix.n; i++){
            for (int j = 0; j < matrix.m; j++){
                result[i, 0] += matrix[i, j] * vector[j];
            }
        }
        return result;
    }

    public static FloatMatrix operator *(FloatMatrix matrix, float scalar){
        FloatMatrix result = new FloatMatrix(matrix.n, matrix.m);
        for (int i = 0; i < matrix.n; i++){
            for (int j = 0; j < matrix.m; j++){
                result[i, j] = matrix[i, j] * scalar;
            }
        }
        return result;
    }

    public static FloatMatrix operator /(FloatMatrix matrix1, FloatMatrix matrix2){
        if (matrix1.n != matrix2.n || matrix1.m != matrix2.m){
            throw new ArgumentException("Matrices must have the same dimensions.");
        }
        FloatMatrix result = new FloatMatrix(matrix1.n, matrix1.m);
        for (int i = 0; i < matrix1.n; i++){
            for (int j = 0; j < matrix1.m; j++){
                result[i, j] = matrix1[i, j] / matrix2[i, j];
            }
        }
        return result;
    }

    public static FloatMatrix operator /(FloatMatrix matrix, float scalar){
        if (scalar == 0){
            throw new DivideByZeroException("Division by zero.");
        }
        FloatMatrix result = new FloatMatrix(matrix.n, matrix.m);
        for (int i = 0; i < matrix.n; i++){
            for (int j = 0; j < matrix.m; j++){
                result[i, j] = matrix[i, j] / scalar;
            }
        }
        return result;
    }

    public static FloatMatrix operator %(FloatMatrix matrix1, FloatMatrix matrix2){
        if (matrix1.n != matrix2.n || matrix1.m != matrix2.m){
            throw new ArgumentException("Matrices must have the same dimensions.");
        }
        FloatMatrix result = new FloatMatrix(matrix1.n, matrix1.m);
        for (int i = 0; i < matrix1.n; i++){
            for (int j = 0; j < matrix1.m; j++){
                result[i, j] = matrix1[i, j] % matrix2[i, j];
            }
        }
        return result;
    }

    public static FloatMatrix operator %(FloatMatrix matrix, float scalar){
        FloatMatrix result = new FloatMatrix(matrix.n, matrix.m);
        for (int i = 0; i < matrix.n; i++){
            for (int j = 0; j < matrix.m; j++){
                result[i, j] = matrix[i, j] % scalar;
            }
        }
        return result;
    }

    //Побітові бінарні операції 
    public static FloatMatrix operator |(FloatMatrix matrix1, FloatMatrix matrix2){
        if (matrix1.n != matrix2.n || matrix1.m != matrix2.m){
            throw new ArgumentException("Matrices must have the same dimensions.");
        }
        FloatMatrix result = new FloatMatrix(matrix1.n, matrix1.m);
        for (int i = 0; i < matrix1.n; i++){
            for (int j = 0; j < matrix1.m; j++){
                result[i, j] = (int)matrix1[i, j] | (int)matrix2[i, j];
            }
        }
        return result;
    }

    public static FloatMatrix operator |(FloatMatrix matrix, float scalar){
        FloatMatrix result = new FloatMatrix(matrix.n, matrix.m);
        for (int i = 0; i < matrix.n; i++){
            for (int j = 0; j < matrix.m; j++){
                result[i, j] = (int)matrix[i, j] | (int)scalar;
            }
        }
        return result;
    }

    public static FloatMatrix operator ^(FloatMatrix matrix1, FloatMatrix matrix2){
        if (matrix1.n != matrix2.n || matrix1.m != matrix2.m){
            throw new ArgumentException("Matrices must have the same dimensions.");
        }
        FloatMatrix result = new FloatMatrix(matrix1.n, matrix1.m);
        for (int i = 0; i < matrix1.n; i++){
            for (int j = 0; j < matrix1.m; j++){
                result[i, j] = (int)matrix1[i, j] ^ (int)matrix2[i, j];
            }
        }
        return result;
    }

    public static FloatMatrix operator ^(FloatMatrix matrix, float scalar){
        FloatMatrix result = new FloatMatrix(matrix.n, matrix.m);
        for (int i = 0; i < matrix.n; i++){
            for (int j = 0; j < matrix.m; j++){
                result[i, j] = (int)matrix[i, j] ^ (int)scalar;
            }
        }
        return result;
    }

    public static FloatMatrix operator &(FloatMatrix matrix1, FloatMatrix matrix2)
    {
        if (matrix1.n != matrix2.n || matrix1.m != matrix2.m){
            throw new ArgumentException("Matrices must have the same dimensions.");
        }
        FloatMatrix result = new FloatMatrix(matrix1.n, matrix1.m);
        for (int i = 0; i < matrix1.n; i++){
            for (int j = 0; j < matrix1.m; j++){
                result[i, j] = (int)matrix1[i, j] & (int)matrix2[i, j];
            }
        }
        return result;
    }

    public static FloatMatrix operator &(FloatMatrix matrix, float scalar){
        FloatMatrix result = new FloatMatrix(matrix.n, matrix.m);
        for (int i = 0; i < matrix.n; i++){
            for (int j = 0; j < matrix.m; j++){
                result[i, j] = (int)matrix[i, j] & (int)scalar;
            }
        }
        return result;
    }

    public static FloatMatrix operator >>(FloatMatrix matrix1, FloatMatrix matrix2){
        if (matrix1.n != matrix2.n || matrix1.m != matrix2.m){
            throw new ArgumentException("Matrices must have the same dimensions.");
        }
        FloatMatrix result = new FloatMatrix(matrix1.n, matrix1.m);
        for (int i = 0; i < matrix1.n; i++){
            for (int j = 0; j < matrix1.m; j++){
                byte[] bytes1 = BitConverter.GetBytes(matrix1[i, j]);
                byte[] bytes2 = BitConverter.GetBytes(matrix2[i, j]);
                for (int k = 0; k < bytes1.Length; k++){
                    bytes1[k] >>= bytes2[k];
                }
                float value = BitConverter.ToSingle(bytes1, 0);
                result[i, j] = value;
            }
        }
        return result;
    }

    public static FloatMatrix operator >>(FloatMatrix matrix, ushort scalar){
        FloatMatrix result = new FloatMatrix(matrix.n, matrix.m);
        byte[] scalarBytes = BitConverter.GetBytes(scalar);
        for (int i = 0; i < matrix.n; i++){
            for (int j = 0; j < matrix.m; j++){
                byte[] matrixBytes = BitConverter.GetBytes(matrix[i, j]);
                for (int k = 0; k < matrixBytes.Length; k++){
                    matrixBytes[k] >>= scalarBytes[k];
                }
                float value = BitConverter.ToSingle(matrixBytes, 0);
                result[i, j] = value;
            }
        }
        return result;
    }

    public static FloatMatrix operator <<(FloatMatrix matrix1, FloatMatrix matrix2){
        if (matrix1.n != matrix2.n || matrix1.m != matrix2.m){
            throw new ArgumentException("Matrices must have the same dimensions.");
        }
        FloatMatrix result = new FloatMatrix(matrix1.n, matrix1.m);
        for (int i = 0; i < matrix1.n; i++){
            for (int j = 0; j < matrix1.m; j++){
                byte[] bytes1 = BitConverter.GetBytes(matrix1[i, j]);
                byte[] bytes2 = BitConverter.GetBytes(matrix2[i, j]);
                for (int k = 0; k < bytes1.Length; k++){
                    bytes1[k] <<= bytes2[k];
                }
                float value = BitConverter.ToSingle(bytes1, 0);
                result[i, j] = value;
            }
        }
        return result;
    }

    public static FloatMatrix operator <<(FloatMatrix matrix, ushort scalar){
        FloatMatrix result = new FloatMatrix(matrix.n, matrix.m);
        byte[] scalarBytes = BitConverter.GetBytes(scalar);
        for (int i = 0; i < matrix.n; i++){
            for (int j = 0; j < matrix.m; j++){
                byte[] matrixBytes = BitConverter.GetBytes(matrix[i, j]);
                for (int k = 0; k < matrixBytes.Length; k++){
                    matrixBytes[k] <<= scalarBytes[k];
                }
                float value = BitConverter.ToSingle(matrixBytes, 0);
                result[i, j] = value;
            }
        }
        return result;
    }

    public static bool operator ==(FloatMatrix matrix1, FloatMatrix matrix2){
        if (matrix1.n != matrix2.n || matrix1.m != matrix2.m){
           return false;
        }
        for (int i = 0; i < matrix1.n; i++){
            for (int j = 0; j < matrix1.m; j++){
                if (matrix1[i, j] != matrix2[i, j])
                    return false;
            }
        }
        return true;
    }

    public static bool operator !=(FloatMatrix matrix1, FloatMatrix matrix2){
        if (matrix1.n != matrix2.n || matrix1.m != matrix2.m){
           return false;
        }
        for (int i = 0; i < matrix1.n; i++){
            for (int j = 0; j < matrix1.m; j++){
                if (matrix1[i, j] != matrix2[i, j])
                    return true;
            }
        }
        return false;
    }

    //Порівняння
    public static bool operator >(FloatMatrix matrix1, FloatMatrix matrix2){
        if (matrix1.n != matrix2.n || matrix1.m != matrix2.m){
            throw new ArgumentException("Matrices must have the same dimensions.");
        }
        for (int i = 0; i < matrix1.n; i++){
            for (int j = 0; j < matrix1.m; j++){
                if (matrix1[i, j] <= matrix2[i, j])
                    return false;
            }
        }
        return true;
    }

    public static bool operator <(FloatMatrix matrix1, FloatMatrix matrix2){
        if (matrix1.n != matrix2.n || matrix1.m != matrix2.m){
            throw new ArgumentException("Matrices must have the same dimensions.");
        }
        for (int i = 0; i < matrix1.n; i++){
            for (int j = 0; j < matrix1.m; j++){
                if (matrix1[i, j] >= matrix2[i, j])
                    return false;
            }
        }
        return true;
    }

    public static bool operator >=(FloatMatrix matrix1, FloatMatrix matrix2){
        if (matrix1.n != matrix2.n || matrix1.m != matrix2.m){
            throw new ArgumentException("Matrices must have the same dimensions.");
        }
        for (int i = 0; i < matrix1.n; i++){
            for (int j = 0; j < matrix1.m; j++){
                if (matrix1[i, j] < matrix2[i, j])
                    return false;
            }
        }
        return true;
    }

    public static bool operator <=(FloatMatrix matrix1, FloatMatrix matrix2){
        if (matrix1.n != matrix2.n || matrix1.m != matrix2.m){
            throw new ArgumentException("Matrices must have the same dimensions.");
        }
        for (int i = 0; i < matrix1.n; i++){
            for (int j = 0; j < matrix1.m; j++){
                if (matrix1[i, j] > matrix2[i, j])
                    return false;
            }
        }
        return true;
    }
}
