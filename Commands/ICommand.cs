﻿/*************************************************************************************************
* 
* THIS CODE AND INFORMATION ARE PROVIDED AS IS WITHOUT WARRANTY OF ANY
* KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
* IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
* PARTICULAR PURPOSE.
* 
*************************************************************************************************/
namespace Figaro.Utilities.Commands
{
    interface ICommand
    {
        void Execute(FigaroContext context, string args);
    }
}