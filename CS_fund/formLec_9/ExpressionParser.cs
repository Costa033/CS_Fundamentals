using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formLec_9
{
    public static class ExpressionParser
    {

        private const string MathSymbols = "+*/^%";

        public static ExpressionOperands Parsez(string input)
        {
            var Operands = new ExpressionOperands();
            var token = "";
            bool LeftOperandInitialized=false;


            for (int i=0;i<input.Length;i++)
            {
                char CurrentChar = input[i];

                //Numbers
                if(char.IsDigit(CurrentChar))
                {
                    token += CurrentChar;
                    if(i==(input.Length-1))
                    {
                        Operands.RightSideOperand=double.Parse(token); 
                        break;
                    }
                }

                //Symbols
                else if (MathSymbols.Contains(CurrentChar))
                {
                    if(!LeftOperandInitialized)
                    {
                        Operands.LeftSideOperand = double.Parse(token);
                        token = "";
                        LeftOperandInitialized = true;
                    }
                    Operands.Symbol= ParseOperationSymbol(CurrentChar.ToString());
                    
                }

                //Letters
                else if (char.IsLetter(CurrentChar))
                {

                    // 34an lw mfee4 left side aslan EX:  tan 90
                    if(!LeftOperandInitialized)
                        LeftOperandInitialized= true;
                   token+= CurrentChar;
                }

                // White Spaces
                else if (CurrentChar==' ')
                {
                    if(!LeftOperandInitialized && token.Length>0)
                    {
                        Operands.LeftSideOperand = double.Parse(token);
                        token= "";
                        LeftOperandInitialized = true;
                    }
                    else if(LeftOperandInitialized  &&  Operands.Symbol==OperationSymbols.None)
                    {
                        Operands.Symbol= ParseOperationSymbol(token);
                        token= "";

                    }

                    // De mn Costa bfadl allah ........ mt3mlt4 fe el video
                    // kan fe error lw 3mlt white space b3d right operand 
                    // el kood da 7lhaaa
                    else if(LeftOperandInitialized && Operands.Symbol != OperationSymbols.None && token.Length>0)
                    {
                        Operands.RightSideOperand= double.Parse(token);
                    }
                    

                }

                //Negative
                else if(CurrentChar == '-')
                {
                    if(!LeftOperandInitialized && token.Length==0)
                    {
                        token += CurrentChar;
                    }

                    else if (!LeftOperandInitialized &&  Operands.Symbol==OperationSymbols.None   && token.Length != 0)
                    {
                        Operands.Symbol= ParseOperationSymbol(CurrentChar.ToString());
                        Operands.LeftSideOperand= double.Parse(token);
                        LeftOperandInitialized= true;
                        token = "";
                        
                    }

                    else if(LeftOperandInitialized && Operands.Symbol!=OperationSymbols.None)
                    {
                        token+= CurrentChar;
                    }
                    else if (LeftOperandInitialized && Operands.Symbol == OperationSymbols.None)
                    {
                        Operands.Symbol = ParseOperationSymbol(CurrentChar.ToString());
                    }
                }





            }









            return Operands;
        }

        private static OperationSymbols ParseOperationSymbol(string OperationSymbol)
        {
            switch (OperationSymbol.ToLower())
            {
                case "+":
                    return OperationSymbols.addition;
                case "-":
                    return OperationSymbols.subtraction;
                case "*":
                    return OperationSymbols.multiblication;
                case "/":
                    return OperationSymbols.division;
                case "%":
                case "mod":
                    return OperationSymbols.modulus;
                case "^":
                case "pow":
                    return OperationSymbols.power;
                case "sin":
                    return OperationSymbols.sin;
                case "cos":
                    return OperationSymbols.cos;
                case "tan":
                    return OperationSymbols.tan;

                default:
                    return OperationSymbols.None;

            }




        }
    }
   
}
