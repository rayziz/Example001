﻿Console.WriteLine("Добрый день. Я универсальный помощник по напоминанию дня недели");
Console.WriteLine("От Вас требуется указать только порядковый номер дня недели, а всё остальное я беру на себя)");
string strValue = Console.ReadLine();
int value = int.Parse(strValue);
if (value == 1) Console.WriteLine("Понедельник");
if (value == 2) Console.WriteLine("Вторник");
if (value == 3) Console.WriteLine("Среда");
if (value == 4) Console.WriteLine("Четверг");
if (value == 5) Console.WriteLine("Пятница");
if (value == 6) Console.WriteLine("Суббота");
if (value == 7) Console.WriteLine("Воскресенье");
if (value >7) Console.WriteLine("В неделе всего 7 дней глупец АХАХАХАх кхм кхм кхм, ох уж этот ковид достал уже");
// Можно после каждого IF нафигачить else. Else Ставится после точки с запятой. А потом ниже само условие Else прописать.