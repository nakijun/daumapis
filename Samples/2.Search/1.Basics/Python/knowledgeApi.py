﻿import simplejson, urllib
apikey = "DAUM_SEARCH_DEMO_APIKEY"
SEARCH_BASE ="http://apis.daum.net/search/knowledge"

def search(query, **args):
    args.update({
            'apikey': apikey,
            'q': query,
            'output': 'json'
    })

    url = SEARCH_BASE + '?' + urllib.urlencode(args)
    result = simplejson.load(urllib.urlopen(url))

    return result['channel']

info = search('OpenAPI')
for item in info['item']:
    print item['title']