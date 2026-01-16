\
\ @file usbsram_s.fs
\ @brief USBSRAM address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Channel/endpoint transmit buffer descriptor 0
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$0000ffff constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_0_ADDR_TX          \ Transmission buffer address
$03ff0000 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_0_COUNT_TX         \ Transmission byte count


\
\ @brief Channel/endpoint receive buffer descriptor 0
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$0000ffff constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_0_ALTERNATE1_ADDR_RX    \ Reception buffer address
$03ff0000 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_0_ALTERNATE1_COUNT_RX    \ Reception byte count
$7c000000 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_0_ALTERNATE1_NUM_BLOCK    \ Number of blocks
$80000000 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_0_ALTERNATE1_BLSIZE    \ Block size


\
\ @brief Channel/endpoint receive buffer descriptor 0
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000ffff constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_0_ADDR_RX          \ Reception buffer address
$03ff0000 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_0_COUNT_RX         \ Reception byte count
$7c000000 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_0_NUM_BLOCK        \ Number of blocks
$80000000 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_0_BLSIZE           \ Block size


\
\ @brief Channel/endpoint transmit buffer descriptor 0
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000ffff constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_0_ALTERNATE1_ADDR_TX    \ Transmission buffer address
$03ff0000 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_0_ALTERNATE1_COUNT_TX    \ Transmission byte count


\
\ @brief Channel/endpoint transmit buffer descriptor 1
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000ffff constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_1_ADDR_TX          \ Transmission buffer address
$03ff0000 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_1_COUNT_TX         \ Transmission byte count


\
\ @brief Channel/endpoint receive buffer descriptor 1
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000ffff constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_1_ALTERNATE1_ADDR_RX    \ Reception buffer address
$03ff0000 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_1_ALTERNATE1_COUNT_RX    \ Reception byte count
$7c000000 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_1_ALTERNATE1_NUM_BLOCK    \ Number of blocks
$80000000 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_1_ALTERNATE1_BLSIZE    \ Block size


\
\ @brief Channel/endpoint receive buffer descriptor 1
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_1_ADDR_RX          \ Reception buffer address
$03ff0000 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_1_COUNT_RX         \ Reception byte count
$7c000000 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_1_NUM_BLOCK        \ Number of blocks
$80000000 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_1_BLSIZE           \ Block size


\
\ @brief Channel/endpoint transmit buffer descriptor 1
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_1_ALTERNATE1_ADDR_TX    \ Transmission buffer address
$03ff0000 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_1_ALTERNATE1_COUNT_TX    \ Transmission byte count


\
\ @brief Channel/endpoint transmit buffer descriptor 2
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000ffff constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_2_ADDR_TX          \ Transmission buffer address
$03ff0000 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_2_COUNT_TX         \ Transmission byte count


\
\ @brief Channel/endpoint receive buffer descriptor 2
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000ffff constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_2_ALTERNATE1_ADDR_RX    \ Reception buffer address
$03ff0000 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_2_ALTERNATE1_COUNT_RX    \ Reception byte count
$7c000000 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_2_ALTERNATE1_NUM_BLOCK    \ Number of blocks
$80000000 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_2_ALTERNATE1_BLSIZE    \ Block size


\
\ @brief Channel/endpoint receive buffer descriptor 2
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_2_ADDR_RX          \ Reception buffer address
$03ff0000 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_2_COUNT_RX         \ Reception byte count
$7c000000 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_2_NUM_BLOCK        \ Number of blocks
$80000000 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_2_BLSIZE           \ Block size


\
\ @brief Channel/endpoint transmit buffer descriptor 2
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_2_ALTERNATE1_ADDR_TX    \ Transmission buffer address
$03ff0000 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_2_ALTERNATE1_COUNT_TX    \ Transmission byte count


\
\ @brief Channel/endpoint transmit buffer descriptor 3
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000ffff constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_3_ADDR_TX          \ Transmission buffer address
$03ff0000 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_3_COUNT_TX         \ Transmission byte count


\
\ @brief Channel/endpoint receive buffer descriptor 3
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000ffff constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_3_ALTERNATE1_ADDR_RX    \ Reception buffer address
$03ff0000 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_3_ALTERNATE1_COUNT_RX    \ Reception byte count
$7c000000 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_3_ALTERNATE1_NUM_BLOCK    \ Number of blocks
$80000000 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_3_ALTERNATE1_BLSIZE    \ Block size


\
\ @brief Channel/endpoint receive buffer descriptor 3
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000ffff constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_3_ADDR_RX          \ Reception buffer address
$03ff0000 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_3_COUNT_RX         \ Reception byte count
$7c000000 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_3_NUM_BLOCK        \ Number of blocks
$80000000 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_3_BLSIZE           \ Block size


\
\ @brief Channel/endpoint transmit buffer descriptor 3
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000ffff constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_3_ALTERNATE1_ADDR_TX    \ Transmission buffer address
$03ff0000 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_3_ALTERNATE1_COUNT_TX    \ Transmission byte count


\
\ @brief Channel/endpoint transmit buffer descriptor 4
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000ffff constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_4_ADDR_TX          \ Transmission buffer address
$03ff0000 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_4_COUNT_TX         \ Transmission byte count


\
\ @brief Channel/endpoint receive buffer descriptor 4
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000ffff constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_4_ALTERNATE1_ADDR_RX    \ Reception buffer address
$03ff0000 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_4_ALTERNATE1_COUNT_RX    \ Reception byte count
$7c000000 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_4_ALTERNATE1_NUM_BLOCK    \ Number of blocks
$80000000 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_4_ALTERNATE1_BLSIZE    \ Block size


\
\ @brief Channel/endpoint receive buffer descriptor 4
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_4_ADDR_RX          \ Reception buffer address
$03ff0000 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_4_COUNT_RX         \ Reception byte count
$7c000000 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_4_NUM_BLOCK        \ Number of blocks
$80000000 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_4_BLSIZE           \ Block size


\
\ @brief Channel/endpoint transmit buffer descriptor 4
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_4_ALTERNATE1_ADDR_TX    \ Transmission buffer address
$03ff0000 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_4_ALTERNATE1_COUNT_TX    \ Transmission byte count


\
\ @brief Channel/endpoint transmit buffer descriptor 5
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_5_ADDR_TX          \ Transmission buffer address
$03ff0000 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_5_COUNT_TX         \ Transmission byte count


\
\ @brief Channel/endpoint receive buffer descriptor 5
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_5_ALTERNATE1_ADDR_RX    \ Reception buffer address
$03ff0000 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_5_ALTERNATE1_COUNT_RX    \ Reception byte count
$7c000000 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_5_ALTERNATE1_NUM_BLOCK    \ Number of blocks
$80000000 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_5_ALTERNATE1_BLSIZE    \ Block size


\
\ @brief Channel/endpoint receive buffer descriptor 5
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000ffff constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_5_ADDR_RX          \ Reception buffer address
$03ff0000 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_5_COUNT_RX         \ Reception byte count
$7c000000 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_5_NUM_BLOCK        \ Number of blocks
$80000000 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_5_BLSIZE           \ Block size


\
\ @brief Channel/endpoint transmit buffer descriptor 5
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000ffff constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_5_ALTERNATE1_ADDR_TX    \ Transmission buffer address
$03ff0000 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_5_ALTERNATE1_COUNT_TX    \ Transmission byte count


\
\ @brief Channel/endpoint transmit buffer descriptor 6
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000ffff constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_6_ADDR_TX          \ Transmission buffer address
$03ff0000 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_6_COUNT_TX         \ Transmission byte count


\
\ @brief Channel/endpoint receive buffer descriptor 6
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000ffff constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_6_ALTERNATE1_ADDR_RX    \ Reception buffer address
$03ff0000 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_6_ALTERNATE1_COUNT_RX    \ Reception byte count
$7c000000 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_6_ALTERNATE1_NUM_BLOCK    \ Number of blocks
$80000000 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_6_ALTERNATE1_BLSIZE    \ Block size


\
\ @brief Channel/endpoint receive buffer descriptor 6
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_6_ADDR_RX          \ Reception buffer address
$03ff0000 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_6_COUNT_RX         \ Reception byte count
$7c000000 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_6_NUM_BLOCK        \ Number of blocks
$80000000 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_6_BLSIZE           \ Block size


\
\ @brief Channel/endpoint transmit buffer descriptor 6
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_6_ALTERNATE1_ADDR_TX    \ Transmission buffer address
$03ff0000 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_6_ALTERNATE1_COUNT_TX    \ Transmission byte count


\
\ @brief Channel/endpoint transmit buffer descriptor 7
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000ffff constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_7_ADDR_TX          \ Transmission buffer address
$03ff0000 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_7_COUNT_TX         \ Transmission byte count


\
\ @brief Channel/endpoint receive buffer descriptor 7
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000ffff constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_7_ALTERNATE1_ADDR_RX    \ Reception buffer address
$03ff0000 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_7_ALTERNATE1_COUNT_RX    \ Reception byte count
$7c000000 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_7_ALTERNATE1_NUM_BLOCK    \ Number of blocks
$80000000 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_7_ALTERNATE1_BLSIZE    \ Block size


\
\ @brief Channel/endpoint receive buffer descriptor 7
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$0000ffff constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_7_ADDR_RX          \ Reception buffer address
$03ff0000 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_7_COUNT_RX         \ Reception byte count
$7c000000 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_7_NUM_BLOCK        \ Number of blocks
$80000000 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_7_BLSIZE           \ Block size


\
\ @brief Channel/endpoint transmit buffer descriptor 7
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$0000ffff constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_7_ALTERNATE1_ADDR_TX    \ Transmission buffer address
$03ff0000 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_7_ALTERNATE1_COUNT_TX    \ Transmission byte count


\
\ @brief USBSRAM address block description
\
$50016400 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_0  \ offset: 0x00 : Channel/endpoint transmit buffer descriptor 0
$50016400 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_0_ALTERNATE1  \ offset: 0x00 : Channel/endpoint receive buffer descriptor 0
$50016404 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_0  \ offset: 0x04 : Channel/endpoint receive buffer descriptor 0
$50016404 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_0_ALTERNATE1  \ offset: 0x04 : Channel/endpoint transmit buffer descriptor 0
$50016408 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_1  \ offset: 0x08 : Channel/endpoint transmit buffer descriptor 1
$50016408 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_1_ALTERNATE1  \ offset: 0x08 : Channel/endpoint receive buffer descriptor 1
$5001640c constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_1  \ offset: 0x0C : Channel/endpoint receive buffer descriptor 1
$5001640c constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_1_ALTERNATE1  \ offset: 0x0C : Channel/endpoint transmit buffer descriptor 1
$50016410 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_2  \ offset: 0x10 : Channel/endpoint transmit buffer descriptor 2
$50016410 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_2_ALTERNATE1  \ offset: 0x10 : Channel/endpoint receive buffer descriptor 2
$50016414 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_2  \ offset: 0x14 : Channel/endpoint receive buffer descriptor 2
$50016414 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_2_ALTERNATE1  \ offset: 0x14 : Channel/endpoint transmit buffer descriptor 2
$50016418 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_3  \ offset: 0x18 : Channel/endpoint transmit buffer descriptor 3
$50016418 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_3_ALTERNATE1  \ offset: 0x18 : Channel/endpoint receive buffer descriptor 3
$5001641c constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_3  \ offset: 0x1C : Channel/endpoint receive buffer descriptor 3
$5001641c constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_3_ALTERNATE1  \ offset: 0x1C : Channel/endpoint transmit buffer descriptor 3
$50016420 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_4  \ offset: 0x20 : Channel/endpoint transmit buffer descriptor 4
$50016420 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_4_ALTERNATE1  \ offset: 0x20 : Channel/endpoint receive buffer descriptor 4
$50016424 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_4  \ offset: 0x24 : Channel/endpoint receive buffer descriptor 4
$50016424 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_4_ALTERNATE1  \ offset: 0x24 : Channel/endpoint transmit buffer descriptor 4
$50016428 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_5  \ offset: 0x28 : Channel/endpoint transmit buffer descriptor 5
$50016428 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_5_ALTERNATE1  \ offset: 0x28 : Channel/endpoint receive buffer descriptor 5
$5001642c constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_5  \ offset: 0x2C : Channel/endpoint receive buffer descriptor 5
$5001642c constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_5_ALTERNATE1  \ offset: 0x2C : Channel/endpoint transmit buffer descriptor 5
$50016430 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_6  \ offset: 0x30 : Channel/endpoint transmit buffer descriptor 6
$50016430 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_6_ALTERNATE1  \ offset: 0x30 : Channel/endpoint receive buffer descriptor 6
$50016434 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_6  \ offset: 0x34 : Channel/endpoint receive buffer descriptor 6
$50016434 constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_6_ALTERNATE1  \ offset: 0x34 : Channel/endpoint transmit buffer descriptor 6
$50016438 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_7  \ offset: 0x38 : Channel/endpoint transmit buffer descriptor 7
$50016438 constant USBSRAM_S_USBSRAM_CHEP_TXRXBD_7_ALTERNATE1  \ offset: 0x38 : Channel/endpoint receive buffer descriptor 7
$5001643c constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_7  \ offset: 0x3C : Channel/endpoint receive buffer descriptor 7
$5001643c constant USBSRAM_S_USBSRAM_CHEP_RXTXBD_7_ALTERNATE1  \ offset: 0x3C : Channel/endpoint transmit buffer descriptor 7

