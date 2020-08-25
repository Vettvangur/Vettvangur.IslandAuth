using System;
using System.Collections.Generic;
using System.Text;

namespace Vettvangur.IcelandAuth.Tests
{
    static class Resources
    {
        public const string OnetimeValidSaml = "PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiPz48UmVzcG9uc2UgeG1sbnM6eHNkPSJodHRwOi8vd3d3LnczLm9yZy8yMDAxL1hNTFNjaGVtYSIgeG1sbnM6eHNpPSJodHRwOi8vd3d3LnczLm9yZy8yMDAxL1hNTFNjaGVtYS1pbnN0YW5jZSIgSUQ9Il8wN2JhM2RmMC0zNGIyLTRkOTAtOGQ0OC1lZmMyNWNmNDA5MDIiIFZlcnNpb249IjIuMCIgSXNzdWVJbnN0YW50PSIyMDIwLTA4LTI1VDE3OjI2OjIyLjI1NzM3OTZaIiBEZXN0aW5hdGlvbj0iaHR0cHM6Ly9pY2VsYW5kYXV0aC52ZXR0dmFuZ3VyLmlzL3VtYnJhY28vc3VyZmFjZS9pY2VsYW5kYXV0aC9sb2dpbiIgeG1sbnM9InVybjpvYXNpczpuYW1lczp0YzpTQU1MOjIuMDpwcm90b2NvbCI+PElzc3VlciB4bWxucz0idXJuOm9hc2lzOm5hbWVzOnRjOlNBTUw6Mi4wOmFzc2VydGlvbiI+SW5uc2tyYW5pbmc8L0lzc3Vlcj48U2lnbmF0dXJlIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwLzA5L3htbGRzaWcjIj48U2lnbmVkSW5mbz48Q2Fub25pY2FsaXphdGlvbk1ldGhvZCBBbGdvcml0aG09Imh0dHA6Ly93d3cudzMub3JnL1RSLzIwMDEvUkVDLXhtbC1jMTRuLTIwMDEwMzE1IiAvPjxTaWduYXR1cmVNZXRob2QgQWxnb3JpdGhtPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwLzA5L3htbGRzaWcjcnNhLXNoYTEiIC8+PFJlZmVyZW5jZSBVUkk9IiI+PFRyYW5zZm9ybXM+PFRyYW5zZm9ybSBBbGdvcml0aG09Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvMDkveG1sZHNpZyNlbnZlbG9wZWQtc2lnbmF0dXJlIiAvPjxUcmFuc2Zvcm0gQWxnb3JpdGhtPSJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzEwL3htbC1leGMtYzE0biMiIC8+PC9UcmFuc2Zvcm1zPjxEaWdlc3RNZXRob2QgQWxnb3JpdGhtPSJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGVuYyNzaGEyNTYiIC8+PERpZ2VzdFZhbHVlPm5GQ1RSQmZFekJtUXFBdndPZ3Q1aktOWnZHZ0xSZ09ZUVJSdmpBOFBRK289PC9EaWdlc3RWYWx1ZT48L1JlZmVyZW5jZT48L1NpZ25lZEluZm8+PFNpZ25hdHVyZVZhbHVlPkkvYzhmNkJTTSt4M1VWcHExZW5MaHYraFRuOGxFMXFiMCtGV2NaenhJOEt3L3JUVzk2c012eEhjaGRHcStpdWkwd0FZcm5jRXRJbjVOQWJEbzEvbTZFYStqWGtRN01HNC9DVlBLSVNSeTJwQm5CTGwyc2h6OWhrZTVwMUtLdExickw3b2lOR2pRWC9wdUlYL2RidVJ0cEtEbThiYURjeTAyaHJ5NzZDemNHWXI0R3JoZjBkOXdSWVk5TnlLM1QwMlhtQnBvUDJhbnBqZlVMSnJWNGlvcjQ5a0k0aktPMXpTeWtOc0sxd1gvcEdWd0xRZG53ZnFQa0szYncrcWdralVrblBWUGJxdmJZVnlyTWdleWFNS1FYa2l0elR2NGpFUmFTTSticUNBcnFVUTJUdzNYK0UvQ3hBa0ZmbXY1TTZyN2RrdjZPdHpyNFJVanpVY0tsTFFvUT09PC9TaWduYXR1cmVWYWx1ZT48S2V5SW5mbz48WDUwOURhdGE+PFg1MDlDZXJ0aWZpY2F0ZT5NSUlHRERDQ0JQU2dBd0lCQWdJQ0xMY3dEUVlKS29aSWh2Y05BUUVGQlFBd2daSXhDekFKQmdOVkJBWVRBa2xUTVJNd0VRWURWUVFGRXdvMU1qRXdNREF5Tnprd01SWXdGQVlEVlFRS0V3MUJkV1JyWlc1dWFTQmxhR1l1TVNNd0lRWURWUVFMRXhwVmRHZGxabUZ1WkdrZ1luVnVZV1JoY25OcmFXeHlhV3RxWVRFV01CUUdBMVVFQ3hNTlRXbHNiR2x6YTJsc2NtbHJhVEVaTUJjR0ExVUVBeE1RVkhKaGRYTjBkWElnWW5WdVlXUjFjakFlRncweE9EQTNNRE14TlRJME5EaGFGdzB5TVRBM01ETXhOVEkwTkRoYU1JSENNUXN3Q1FZRFZRUUdFd0pKVXpFZU1Cd0dBMVVFQ2d3Vnc1NXF3N1BEc0hOcmNzT2hJTU9OYzJ4aGJtUnpNUmd3RmdZRFZRUUxFdzlDZFc1aFpHRnljMnRwYkhKcGEya3hKVEFqQmdOVkJBc01IRlZ1WkdseWNtbDBkVzRnWmNPd1lTQmhkY093YTJWdWJtbHVaeUF4SFRBYkJna3Foa2lHOXcwQkNRRVdEblpsY210QWFYTnNZVzVrTG1sek1STXdFUVlEVlFRRkV3bzJOVEF6TnpZd05qUTVNUjR3SEFZRFZRUURFeFZKYm01emEzSmhibWx1WnlCSmMyeGhibVF1YVhNd2dnRWlNQTBHQ1NxR1NJYjNEUUVCQVFVQUE0SUJEd0F3Z2dFS0FvSUJBUUM0cXRtYlBMS0t3WXJnZlhCSEYvdGJBNDhuemdsTmZnc3U2ZlN1ZFJld2dEejRvL2EvRHRkVjc5bG5OMk5kWEM1ZHNBMlJpS1gxUW9JaFh0cFBIazVPbWpjMUk3cmRqaFFkQUF6N2dEVzlvcUFDSHg0Q29RclNrNno4QlovZXFqdVQzRSs3RXdyQWFHZkN3RDVZYzFKRWxiVUpleXV1U0pCZ0hVV3lreDd4MUZsZW5jMytpOGhwdzlFMFkya3RqMkFpUmQ1K0J2NldHaTduNTBjL0FrajRidmNVNmRhdkRLRWJkZVZrNmxYeEFjOUJyYk5aY28wTDZmRS93dHF0S3E2WTl3VUdmWC9rR2RaazV3eFIrTkxPZzhCWEdLZWZMc1k4NDlKTXJNc241QTJrRGlGODZ4Z2pEUVhLRmV0QnNXVjR5VjhLY2hoMnp2Q29wcVpieG5WZEFnTUJBQUdqZ2dJNE1JSUNOREFNQmdOVkhSTUJBZjhFQWpBQU1JSUJIQVlEVlIwZ0JJSUJFekNDQVE4d2dnRUxCZ2xnZ21BQkFnRUJCQUV3Z2Ywd2djUUdDQ3NHQVFVRkJ3SUNNSUczR29HMFZHaHBjeUJqWlhKMGFXWnBZMkYwWlNCcGN5QnBiblJsYm1SbFpDQm1iM0lnWkdsbmFYUmhiQ0J6YVdkdVlYUjFjbVZ6SUdGdVpDQmhkWFJvWlc1MGFXTmhkR2x2Ymk0Z1ZHaHBjeUJqWlhKMGFXWnBZMkYwWlNCbWRXeG1hV3h6SUhSb1pTQnlaWEYxYVhKbGJXVnVkSE1nYjJZZ2JtOXliV0ZzYVhwbFpDQmpaWEowYVdacFkyRjBaU0J3YjJ4cFkza2dLRTVEVUNrZ1pHVm1hVzVsWkNCcGJpQkZWRk5KSUZSVElERXdNaUF3TkRJdU1EUUdDQ3NHQVFVRkJ3SUJGaWhvZEhSd09pOHZZM0F1WVhWa2EyVnVibWt1YVhNdmRISmhkWE4wZFhKaWRXNWhaSFZ5TDJOd01ITUdDQ3NHQVFVRkJ3RUJCR2N3WlRBakJnZ3JCZ0VGQlFjd0FvWVhhSFIwY0RvdkwyOWpjM0F1WVhWa2EyVnVibWt1YVhNd1BnWUhZSUpnQWdGakJvWXphSFIwY0RvdkwyTmtjQzVoZFdSclpXNXVhUzVwY3k5emEybHNjbWxyYVM5MGNtRjFjM1IxY21KMWJtRmtkWEl1Y0RkaU1Bc0dBMVVkRHdRRUF3SUY0REFmQmdOVkhTTUVHREFXZ0JSdjdOc1JMQUVEYXh0Z3JyYjRhTmxBQWMyT09EQkNCZ05WSFI4RU96QTVNRGVnTmFBemhqRm9kSFJ3T2k4dlkzSnNMbUYxWkd0bGJtNXBMbWx6TDNSeVlYVnpkSFZ5WW5WdVlXUjFjaTlzWVhSbGMzUXVZM0pzTUIwR0ExVWREZ1FXQkJTelV5TGU0UkNTT0JJbmtJQnNPNUZ4eXREZk1qQU5CZ2txaGtpRzl3MEJBUVVGQUFPQ0FRRUF2amduSDZObUxxc1Vyd29HWXNMMDd3L1M0dko5czhKUFVMcG1JTEZCNmhJS3FXdlVpSm9iN1I5bHNMcEsyb3g0ZUxWLy91ckJsREFTSUZYMWhHYzFWdk51QVNoNHJDVy9qTVpHVTBqejhKbWxpbDNtMDFQWjVUY2FHWFpWUW1kLzhiaU5qZWtieXNLY1d6QnpDQkdkZmF2SUl2Z0p4aTJoVVgzU05lTkhpWDVXbGVyK1VPek5qSHNBbXVETWQ2NW5CWXpkQ0Z5MThEQlp2STY2bE4wMzFGVG5UbjhiaFpid0RaS2FGeEZ3NkpUU2lmdWJEaklVUlpoMklrVk0wUjE1enhmanVOajVsWmwxYmZsN1RTQ3Y0dmx3SEdWWlhZS1R2Y2pSZ25lZUxiUTdwMkVNbDYvb2Q0L1RmQ0IzU0cvWmlBZWc3RzNiRzdRYjVvU1NGKzRYVmc9PTwvWDUwOUNlcnRpZmljYXRlPjwvWDUwOURhdGE+PC9LZXlJbmZvPjwvU2lnbmF0dXJlPjxTdGF0dXM+PFN0YXR1c0NvZGUgVmFsdWU9InVybjpvYXNpczpuYW1lczp0YzpTQU1MOjIuMDpzdGF0dXM6U3VjY2VzcyIgLz48L1N0YXR1cz48QXNzZXJ0aW9uIFZlcnNpb249IjIuMCIgSUQ9Il9jOTc0YjZhMC0xNjYzLTQ5YjktOGMxMi0wNzUzYzZhNTgwYmUiIElzc3VlSW5zdGFudD0iMjAyMC0wOC0yNVQxNzoyNjoyMi4yNTczNzk2WiIgeG1sbnM9InVybjpvYXNpczpuYW1lczp0YzpTQU1MOjIuMDphc3NlcnRpb24iPjxJc3N1ZXI+SW5uc2tyYW5pbmc8L0lzc3Vlcj48U3ViamVjdD48TmFtZUlEIE5hbWVRdWFsaWZpZXI9ImlzbGFuZC5pcyIgLz48U3ViamVjdENvbmZpcm1hdGlvbiBNZXRob2Q9InVybjpvYXNpczpuYW1lczp0YzpTQU1MOjIuMDpjbTpiZWFyZXIiPjxTdWJqZWN0Q29uZmlybWF0aW9uRGF0YSBBZGRyZXNzPSIxOTQuMTQ0LjIxMy4yMDkiIE5vdE9uT3JBZnRlcj0iMjAyMC0wOC0yNVQxNzozMToyMi4yNTczNzk2WiIgUmVjaXBpZW50PSJodHRwczovL2ljZWxhbmRhdXRoLnZldHR2YW5ndXIuaXMvdW1icmFjby9zdXJmYWNlL2ljZWxhbmRhdXRoL2xvZ2luIiAvPjwvU3ViamVjdENvbmZpcm1hdGlvbj48L1N1YmplY3Q+PENvbmRpdGlvbnMgTm90QmVmb3JlPSIyMDIwLTA4LTI1VDE3OjI1OjUyLjI1NzM3OTZaIiBOb3RPbk9yQWZ0ZXI9IjIwMjAtMDgtMjVUMTc6MzE6MjIuMjU3Mzc5NloiPjxBdWRpZW5jZVJlc3RyaWN0aW9uPjxBdWRpZW5jZT5pY2VsYW5kYXV0aC52ZXR0dmFuZ3VyLmlzPC9BdWRpZW5jZT48L0F1ZGllbmNlUmVzdHJpY3Rpb24+PC9Db25kaXRpb25zPjxBdXRoblN0YXRlbWVudCBBdXRobkluc3RhbnQ9IjIwMjAtMDgtMjVUMTc6MjY6MjIuMjU3Mzc5NloiPjxTdWJqZWN0TG9jYWxpdHkgQWRkcmVzcz0iODIuMjIxLjgxLjYwIiAvPjxBdXRobkNvbnRleHQ+PEF1dGhuQ29udGV4dENsYXNzUmVmPnVybjpvYXNpczpuYW1lczp0YzpTQU1MOjIuMDphYzpjbGFzc2VzOlBhc3N3b3JkUHJvdGVjdGVkVHJhbnNwb3J0PC9BdXRobkNvbnRleHRDbGFzc1JlZj48L0F1dGhuQ29udGV4dD48L0F1dGhuU3RhdGVtZW50PjxBdHRyaWJ1dGVTdGF0ZW1lbnQ+PEF0dHJpYnV0ZSBOYW1lPSJVc2VyU1NOIiBOYW1lRm9ybWF0PSJ1cm46b2FzaXM6bmFtZXM6dGM6U0FNTDoyLjA6YXR0cm5hbWUtZm9ybWF0OmJhc2ljIiBGcmllbmRseU5hbWU9Iktlbm5pdGFsYSI+PEF0dHJpYnV0ZVZhbHVlIHhzaTp0eXBlPSJ4c2Q6c3RyaW5nIj4yMDA4ODYyOTE5PC9BdHRyaWJ1dGVWYWx1ZT48L0F0dHJpYnV0ZT48QXR0cmlidXRlIE5hbWU9Ik5hbWUiIE5hbWVGb3JtYXQ9InVybjpvYXNpczpuYW1lczp0YzpTQU1MOjIuMDphdHRybmFtZS1mb3JtYXQ6YmFzaWMiIEZyaWVuZGx5TmFtZT0iTmFmbiI+PEF0dHJpYnV0ZVZhbHVlIHhzaTp0eXBlPSJ4c2Q6c3RyaW5nIj5HdW5uYXIgTcOhciDDk3R0YXJzc29uPC9BdHRyaWJ1dGVWYWx1ZT48L0F0dHJpYnV0ZT48QXR0cmlidXRlIE5hbWU9IkF1dGhlbnRpY2F0aW9uIiBOYW1lRm9ybWF0PSJ1cm46b2FzaXM6bmFtZXM6dGM6U0FNTDoyLjA6YXR0cm5hbWUtZm9ybWF0OmJhc2ljIiBGcmllbmRseU5hbWU9IkF1w7BrZW5uaW5nIj48QXR0cmlidXRlVmFsdWUgeHNpOnR5cGU9InhzZDpzdHJpbmciPsONc2x5a2lsbDwvQXR0cmlidXRlVmFsdWU+PC9BdHRyaWJ1dGU+PEF0dHJpYnV0ZSBOYW1lPSJLZXlBdXRoZW50aWNhdGlvbiIgTmFtZUZvcm1hdD0idXJuOm9hc2lzOm5hbWVzOnRjOlNBTUw6Mi4wOmF0dHJuYW1lLWZvcm1hdDpiYXNpYyIgRnJpZW5kbHlOYW1lPSJWb3R0dW7DjXNseWtpbHMiPjxBdHRyaWJ1dGVWYWx1ZSB4c2k6dHlwZT0ieHNkOnN0cmluZyI+U2tqYWwgw60gaGVpbWFiYW5rYTwvQXR0cmlidXRlVmFsdWU+PC9BdHRyaWJ1dGU+PEF0dHJpYnV0ZSBOYW1lPSJJUEFkZHJlc3MiIE5hbWVGb3JtYXQ9InVybjpvYXNpczpuYW1lczp0YzpTQU1MOjIuMDphdHRybmFtZS1mb3JtYXQ6YmFzaWMiIEZyaWVuZGx5TmFtZT0iSVBUYWxhIj48QXR0cmlidXRlVmFsdWUgeHNpOnR5cGU9InhzZDpzdHJpbmciPjE5NC4xNDQuMjEzLjIwOTwvQXR0cmlidXRlVmFsdWU+PC9BdHRyaWJ1dGU+PEF0dHJpYnV0ZSBOYW1lPSJVc2VyQWdlbnQiIE5hbWVGb3JtYXQ9InVybjpvYXNpczpuYW1lczp0YzpTQU1MOjIuMDphdHRybmFtZS1mb3JtYXQ6YmFzaWMiIEZyaWVuZGx5TmFtZT0iTm90YW5kYVN0cmVuZ3VyIj48QXR0cmlidXRlVmFsdWUgeHNpOnR5cGU9InhzZDpzdHJpbmciPk1vemlsbGEvNS4wIChXaW5kb3dzIE5UIDEwLjA7IFdpbjY0OyB4NjQpIEFwcGxlV2ViS2l0LzUzNy4zNiAoS0hUTUwsIGxpa2UgR2Vja28pIENocm9tZS84NC4wLjQxNDcuMTM1IFNhZmFyaS81MzcuMzY8L0F0dHJpYnV0ZVZhbHVlPjwvQXR0cmlidXRlPjxBdHRyaWJ1dGUgTmFtZT0iRGVzdGluYXRpb25TU04iIE5hbWVGb3JtYXQ9InVybjpvYXNpczpuYW1lczp0YzpTQU1MOjIuMDphdHRybmFtZS1mb3JtYXQ6YmFzaWMiIEZyaWVuZGx5TmFtZT0iS2Vubml0YWxhTcOzdHRha2FuZGEiPjxBdHRyaWJ1dGVWYWx1ZSB4c2k6dHlwZT0ieHNkOnN0cmluZyI+NTIwODEzMDU1MDwvQXR0cmlidXRlVmFsdWU+PC9BdHRyaWJ1dGU+PC9BdHRyaWJ1dGVTdGF0ZW1lbnQ+PC9Bc3NlcnRpb24+PC9SZXNwb25zZT4=";
    }
}
