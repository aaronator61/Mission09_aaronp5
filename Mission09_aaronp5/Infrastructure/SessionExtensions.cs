using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

//Creating a way for us to keep track of what we have in a session.
namespace Mission09_aaronp5.Infrastructure
{
    public static class SessionExetensions
    {
        public static void SetJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T GetJson<T>(this ISession session, string key)
        {
            var sessionData = session.GetString(key);

            return (sessionData == null ? default(T) : JsonSerializer.Deserialize<T>(sessionData));
        }
    }
}
