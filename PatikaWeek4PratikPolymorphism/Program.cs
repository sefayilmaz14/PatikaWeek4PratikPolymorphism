using PatikaWeek4PratikPolymorphism;
//Kare Nesnesi oluşturma ve alan hesaplama
BaseGeometricShape square = new Square { Height=10 , Width = 5};
square.AreaCalculation();
//Dikdörtgen Nesnesi oluşturma ve alan hesaplama
BaseGeometricShape rectangle = new Rectangle { Height=20 , Width = 10 };
rectangle.AreaCalculation();
//Diküçgen Nesnesi oluşturma ve alan hesaplama
BaseGeometricShape triangle = new Triangle { Height=10 , Width = 5 };
triangle.AreaCalculation();