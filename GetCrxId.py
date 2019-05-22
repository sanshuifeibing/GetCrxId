
import hashlib
import base64


def build_id(pub_key_pem):
    pub_key_der = base64.b64decode(pub_key_pem)  # BASE64 jiemi
    print(len(pub_key_der))
    print(pub_key_der),
    sha = hashlib.sha256(pub_key_der).hexdigest()
    print(len(sha))
    for i in sha:
        print(i),
    print('\n'),

    prefix = sha[:32]       # qu qian 32 ge
    for i in prefix:
        print(i),

    reencoded = ""
    ord_a = ord('a')  # ord_a = 97

    print('\n'),
    print(ord_a)

    for old_char in prefix:
        # prefix limian meige yuansu jiashang 'a'(97) eg: c + 'a' = 12 + 97 = 'm'
        code = int(old_char, 16)
        new_char = chr(ord_a + code)
        reencoded += new_char
    return reencoded


def main():
    pub_key = 'MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEA0k9N59vMq/1BP6lwgyxVPeWj6EFTMW+wJqyl+vePi1vKzJBCXWPZ5Ls7PmNaTaAQ5TVC5WVoxveuvaYLGm514Y7EDTrL8BrPWcK73Gw7E/IQyfOC+/Mw6mBnANyWiVAu9qIi2/PWasA2J/XR97kfUfuM716NKUNzBmmju8pfyPu+ee9Zfh0fUclF0g48AJMZaw8g6SxiWnQ8XhABkMHXyqVio5cdt5omupDcZ17HHBXsP3KHNX5Tu8ZDrCbFH566p1WGjM6W2Wr2YffzC8WPyFTS/6eiAde5iVjS2VHqRkmgQvrH794kGUC7ZUitP7p6gYCvhdffqxLQslvga9cPNQIDAQAB'
    id_ = build_id(pub_key)
    print(len(id_))
    print(id_)


if __name__ == '__main__':
    main()
