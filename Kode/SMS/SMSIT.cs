public bool SendSms(string sender, string reciever, string message)
{
    string url = string.Format("{0}?apiKey={1}&senderId={2}&mobile={3}
                                &message={4}&charset={5}",
        UrlBase, ApiKey, sender, reciever, message, CharSet);

    var client = new WebClient();
    return client.DownloadString(url) == "0";
}