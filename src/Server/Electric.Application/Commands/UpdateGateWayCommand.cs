﻿using MediatR;

namespace Electric.Application.Commands
{
    public class UpdateGateWayCommand : IRequest
    {
        public string Id { get; set; }
        public string SeriaNumber { get; set; }
        public string FirmwareVersion { get; set; }
        public string State { get; set; }
        public int Type { get; set; }
        public string IP { get; set; }
        public int? Port { get; set; }
    }
}
