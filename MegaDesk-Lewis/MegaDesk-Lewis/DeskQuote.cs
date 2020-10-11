﻿
using System;
using System.Collections.Generic;
using System.IO;

namespace MegaDesk_Lewis
{
    class DeskQuote
    {
            public string date { get; set; }
            public string clientName { get; set; }
            public int rushDays { get; set; }
            public int price { get; set; }
            public Desk desk { get; set; }


            public void calculatePrice(Desk desk, AddQuote addQuote)
            {

                int basePrice = 200;
                int deskSurface = desk.depth * desk.width;
                int drawersPrice = desk.drawers * 50;
                int rushDays = this.rushDays;
                int extraSurfacePrice = 0;
                int rushDaysPrice = 0;
                int materialPrice = 0;
                int[,] extraCharges = new int[3, 3];

                extraCharges = getRushOrder("rushOrderPrices.txt");


                if (deskSurface > 1000)
                {
                    extraSurfacePrice = deskSurface - 1000;
                }


                switch (addQuote.getMaterial())
                {
                    case "Oak": materialPrice = (int)AddQuote.desktopMaterials.Oak; break;
                    case "Laminate": materialPrice = (int)AddQuote.desktopMaterials.Laminate; break;
                    case "Pine": materialPrice = (int)AddQuote.desktopMaterials.Pine; break;
                    case "Rossewood": materialPrice = (int)AddQuote.desktopMaterials.Rossewood; break;
                    case "Veneer": materialPrice = (int)AddQuote.desktopMaterials.Veneer; break;
                    default: materialPrice = 0; break;
                }

                if (deskSurface > 0 && deskSurface < 1000)
                {
                    switch (rushDays)
                    {
                        case 3: rushDaysPrice = extraCharges[0, 0]; break;
                        case 5: rushDaysPrice = extraCharges[0, 1]; break;
                        case 7: rushDaysPrice = extraCharges[0, 2]; break;
                        default: rushDaysPrice = 0; break;
                    }
                }
                else if (deskSurface >= 1000 && deskSurface <= 2000)
                {
                    switch (rushDays)
                    {
                        case 3: rushDaysPrice = extraCharges[1, 0]; break;
                        case 5: rushDaysPrice = extraCharges[1, 1]; break;
                        case 7: rushDaysPrice = extraCharges[1, 2]; break;
                        default: rushDaysPrice = 0; break;
                    }
                }
                else
                {
                    switch (rushDays)
                    {
                        case 3: rushDaysPrice = extraCharges[2, 0]; break;
                        case 5: rushDaysPrice = extraCharges[2, 1]; break;
                        case 7: rushDaysPrice = extraCharges[2, 2]; break;
                        default: rushDaysPrice = 0; break;
                    }
                }

                this.price = basePrice + extraSurfacePrice + drawersPrice + rushDaysPrice + materialPrice;
            }

            public int[,] getRushOrder(string fileName)
            {

                int[,] extraCarges = new int[3, 3];

                try
                {
                    string[] lines = File.ReadAllLines(fileName);

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            extraCarges[i, j] = int.Parse(lines[j + (3 * i)]);
                        }
                    }
                }
                catch (IOException e)
                {
                    System.Windows.Forms.MessageBox.Show("There was a problem while trying to read the file" + e);
                }
                catch (NullReferenceException ne)
                {
                    System.Windows.Forms.MessageBox.Show("Null point exception " + ne);
                }

                return extraCarges;
            }

            

           
        }
    }

