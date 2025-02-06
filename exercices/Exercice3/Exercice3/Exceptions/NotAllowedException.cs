public class NotAllowedException : Exception {
  public NotAllowedException(string errorMessage) : base(errorMessage)
    { }
}
