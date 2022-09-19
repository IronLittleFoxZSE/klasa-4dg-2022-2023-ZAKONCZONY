using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using UtilitisWpf;

namespace FirstTaskProject.ViewModel
{
    class MainWindowViewModel : ObserverVM
    {
        private int sumResult;

        public int SumResult
        {
            get { return sumResult; }
            set
            {
                sumResult = value;
                OnPropertyChanged();
            }
        }

        private int firstValue;

        public int FirstValue
        {
            get { return firstValue; }
            set 
            { 
                firstValue = value;
                OnPropertyChanged();
            }
        }

        private int secondValue;

        public int SecondValue
        {
            get { return secondValue; }
            set { secondValue = value; }
        }

        private string operationMessage;

        public string OperationMessage
        {
            get { return operationMessage; }
            set
            {
                operationMessage = value;
                OnPropertyChanged();
            }
        }


        private ICommand synchronousSumCommand;

        public ICommand SynchronousSumCommand
        {
            get
            {
                if (synchronousSumCommand == null)
                    synchronousSumCommand = new RelayCommand<object>(o =>
                    {
                        int result = firstValue + secondValue;
                        Thread.Sleep(10000);
                        SumResult = result;
                        OperationMessage = "Operacja zakończona";
                    });
                return synchronousSumCommand;
            }
        }

        private ICommand taskSumCommand;

        public ICommand TaskSumCommand
        {
            get
            {
                if (taskSumCommand == null)
                    taskSumCommand = new RelayCommand<object>(o =>
                    {
                        /*Task newTask = new Task(() =>
                        {
                            int result = firstValue + secondValue;
                            Thread.Sleep(10000);
                            SumResult = result;
                        }
                        );
                        newTask.Start();*/

                        Task.Run(() =>
                        {
                            int result = firstValue + secondValue;
                            Thread.Sleep(10000);
                            SumResult = result;
                        });

                        OperationMessage = "Operacja zakończona (z wątku)";
                    });
                return taskSumCommand;
            }
        }

        private ICommand taskSumTaskMessageCommand;

        public ICommand TaskSumTaskMessageCommand
        {
            get
            {
                if (taskSumTaskMessageCommand == null)
                    taskSumTaskMessageCommand = new RelayCommand<object>(o =>
                    {
                        Task newTask = new Task(() =>
                        {
                            int result = firstValue + secondValue;
                            Thread.Sleep(10000);
                            SumResult = result;
                        }
                        );
                        newTask.Start();

                        Task.Run(() =>
                        {
                            newTask.Wait();
                            OperationMessage = "Operacja zakończona (z  innego wątku)";
                        });

                        /*Task xzzz = Task.Run(() =>
                        {
                            Task newTask = new Task(() =>
                                {
                                    int result = firstValue + secondValue;
                                    Thread.Sleep(10000);
                                    SumResult = result;
                                }
                            );
                            newTask.Start();
                            newTask.Wait();
                            OperationMessage = "Operacja zakończona (z  innego wątku)";
                        }
                        );
                        return xzzz;
                         */

                    });
                return taskSumTaskMessageCommand;
            }
        }

        private ICommand asyncSumCommand;

        public ICommand AsyncSumCommand
        {
            get
            {
                if (asyncSumCommand == null)
                    asyncSumCommand = new RelayCommand<object>(async o =>
                    {
                        //instrukcje
                        SumMethodAsync();
                        /*await Task.Run(() =>
                        {

                            int result = firstValue + secondValue;
                            Thread.Sleep(10000);
                            SumResult = result;
                        }
                        );*/

                        OperationMessage = "Operacja zakończona (z  innego wątku)";
                    });
                return asyncSumCommand;
            }
        }

        private async Task SumMethodAsync()
        {
            //insttrukcje
            await Task.Run(() =>
            {

                int result = firstValue + secondValue;
                Thread.Sleep(10000);
                SumResult = result;
            }
            );

            //kolejne instrukcje
        }

        object lockObject = new Object();

        private ICommand sum_v2Command;

        public ICommand Sum_v2Command
        {
            get
            {
                if (sum_v2Command == null)
                    sum_v2Command = new RelayCommand<object>(o =>
                    {
                        Task.Run(() =>
                        {
                            lock (lockObject)
                            {
                                //int localValue = FirstValue;
                                //Thread.Sleep(500);
                                //localValue += 2;
                                //FirstValue = localValue;
                                FirstValue += 2;
                            }
                        }
                            );

                        Task.Run(() =>
                        {
                            lock (lockObject)
                            {
                                /*int localValue = FirstValue;
                                Thread.Sleep(500);
                                localValue *= 2;
                                FirstValue = localValue;*/
                                FirstValue += 2;
                            }
                        }
                            );

                    });
                return sum_v2Command;
            }
        }
    }
}
