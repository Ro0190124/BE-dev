namespace BACK_END.DTOs.RoomDto
{
    public class RoomHistoryQueryDto
    {
        public string? Search { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 8;
    }
}