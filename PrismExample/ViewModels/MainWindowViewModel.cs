﻿using Prism.Commands;
using Prism.Mvvm;
using PrismExample.Interface;
using PrismExample.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrismExample.ViewModels
{
    public class MainWindowViewModel : Customer
    {
        private readonly ICustomerStore? _customerStore = null;

        public MainWindowViewModel(ICustomerStore customerStore)
        {
            _customerStore = customerStore;
        }

        public ObservableCollection<SaveInput> Customers { get;  set; } = new ObservableCollection<SaveInput>();

        /// <summary>
        /// 選中Item
        /// </summary>
        private SaveInput _selectedCustomer = null;
        public SaveInput SelectedCustomer
        {
            get => _selectedCustomer;
            set
            {
                if (SetProperty<SaveInput>(ref _selectedCustomer, value))
                {
                    Debug.WriteLine( "no customer selected");
                }
            }
        }
        //Load按鈕是否可執行
        private bool CanLoad = true;
        /// <summary>
        /// Load按鈕
        /// </summary>
        private DelegateCommand _commandLoad = null;
        public DelegateCommand CommandLoad =>
            _commandLoad ?? (_commandLoad = new DelegateCommand(CommandLoadExecute));

        /// <summary>
        /// 執行載入
        /// </summary>
        private void CommandLoadExecute()
        {
            CanLoad = false;
            Customers.Clear();
            List<SaveInput> list = _customerStore.GetAll();//載入資料
            foreach (var item in list)
            { 
                Customers.Add(item);
                Debug.WriteLine(LoadInput.cust_id);//測試綁定
            }
        }

        /// <summary>
        /// Load按鈕
        /// </summary>
        private DelegateCommand _commandAdd = null;
        public DelegateCommand CommandAdd =>
            _commandAdd ?? (_commandAdd = new DelegateCommand(CommandAddExecute));

        /// <summary>
        /// 執行載入
        /// </summary>
        private void CommandAddExecute()
        {
            Random r = new Random();
            int cust_no = r.Next(1, 100);
            SaveInput c = new SaveInput() { cust_no = cust_no, cust_name = $"客戶{cust_no}" }; 
            Customers.Add(c);   
          
        }
    }
}
