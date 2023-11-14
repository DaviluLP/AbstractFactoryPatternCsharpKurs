// See https://aka.ms/new-console-template for more information

using AbstractFactoryPatternKurs;

QuadrocopterFactory flyFactory = new QuadroFactory();

ControllerBoard controllerBoard = new ControllerBoard(flyFactory);