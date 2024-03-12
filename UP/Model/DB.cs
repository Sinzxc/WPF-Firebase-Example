using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP
{
    public class DB
    {
       public FirebaseClient firebaseClient = new FirebaseClient(
                "https://libridb-59145-default-rtdb.europe-west1.firebasedatabase.app/",
                new FirebaseOptions
                {
                    AuthTokenAsyncFactory = () => Task.FromResult("MIIEvAIBADANBgkqhkiG9w0BAQEFAASCBKYwggSiAgEAAoIBAQDgbpIHY3NyicaL/UkuSloWLsG9rUq4kGnwbNpat5brL/2woJjlFVBZMAvXR6JiW4ToyEL+OfHYuxdyd2SkL19uLvxSlLdS3PsxrS7JaLOCX2OXrJLJlMhZSM1fJLYd5cBPP1XXKI7n8K4Ty1Y7C8O6yGpSU7wg5FT70FPnOPMloKasLXmx0QS775rxqeRl6I1Qex7f8nj6MlALFz+dbAwdE5W7P9ElJ4Hk1RjvG5HmQxUoB5mMtxRkvtmbNTa7d7eqogBAXKi9JzD6uqra+KylZpZncJ63P0QwERVHQHX+QsL+Mc7izrZYuuLCu+jfj+lJS2c8LbT+6PvuGrmZwtrNAgMBAAECgf8BUKSKZorGoQgIyfMj0ku01ZFNCzbk3fPA9OJSpcC8oAtcfZRnwzg1TZLEMCdDbEXbF1FNLAm+u1nn0ctFKwHkI2JXGYf5dFIEeH9Nrs9edDChMuGpTLXf0A1kAVMP2cjGrhhSqmor8b0TYJ2guvDqp0H4OYVgq/XTg+T59dt23PdMjPmI9h2vGgJ+AUbnl2vPX0tpqNZntWYVtoIihDoXQi+babx9EbYMEMxVemZnExW9DhYXRVl4VEF728yhXGL9XnZbQpQXmeTI4+R29ZTtVgqs9CEL/nckufva5FAN8tK+ITrXkfzZtVoF2gehlXoFAzUqFvh7kSHQE9vu9rECgYEA/yMuYvQqTpON8DN4kBTWOQyzQNYvyPQB3CiYfS5ofVpKy0Zn8NAR4NCUypo84/kdvbN5TtoOAc9FvM/z/Qqjc4Coi2Zib2AtarEuEUlZgEFHEQ4UrQi6c1mx2r/iWTYtPB+yRc56R0DKcy6QABdOSpRSqG72uUxbqb6KELdeP4kCgYEA4TDQXXM3nViV8BEDY7zaumcLWBGX+lOnQc9u3GrF0cVENrlH8SDzjTpatNBhbPF8zLIBhyBd6Xb9PLe7kOrRXakBo7QFUpOm2cPDslWXP8d6LgTSnEQtZAr0LJyW0Jt/u5Eu4zZxfKEjSBwi67TZ4mF8oJp1RKwkZrZzUatPTCUCgYEAvrM0I8Busua1S9mc/sykRmYIwaiWdPR1Q3KQb9i1PySzDPcmD6fmBQzCeiEI7Dkykq1IObjgiVe8v2EL9JH0FAwRbohrgOX5bGrcjQ0vOZ8RGF1W9PK2MivTtTaBX78P1oW2gVjQqttxtuARwA+rdDEjC0RNY7kANoL1vYLhjkkCgYEAqCNPYIcXnlc3VJEPa9flpMotkStJw3HUb3HXP6JFY9Qbk5SR37uPvgI1Gc6A/9vrJ9c9Bsym8huTB1PUK2b4virje3x9gOOX7/6YTr5TeR6S3mthaaYKEimPmQOuI8IHBGBpluLep4SVGFFRzZYyHTJW4H+TUZwKbdqKjg8P3TUCgYB0nzgneGQXgY0a7f9bWDuH3QUhrHC06nZ2dnpC6z0B1J01+RQqZ/L7tkoBekLWEd7q8V9PtusZfD1IdkpWN6xAkwaLGbBHg1fqP8unykiZOJ/Gr1Am34E1kAHRjsjlVibszwcX/G2ez5PpezG55joJfqc/0uepoGnUiTvheep1IA==")
                });
    }
}
