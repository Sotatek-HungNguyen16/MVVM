﻿using Reservoom.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
namespace Reservoom
{
    public class ReservationListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<ReservationViewModel> _reservations;
        public IEnumerable<ReservationViewModel> Reservations => _reservations;
        public ICommand MakeReservationCommand { get; }
        public ReservationListingViewModel()
        {
            _reservations = new ObservableCollection<ReservationViewModel>();
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(1, 4), "Hieu", DateTime.MinValue, DateTime.MaxValue)));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(3, 2), "Hoang", DateTime.MinValue, DateTime.MaxValue)));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(1, 4), "Huong", DateTime.MinValue, DateTime.MaxValue)));
        }
    }
}