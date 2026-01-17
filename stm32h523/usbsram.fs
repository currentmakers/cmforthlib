\
\ @file usbsram.fs
\ @brief USBSRAM address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] USBSRAM_DEF

  [ifdef] USBSRAM_USBSRAM_CHEP_TXRXBD_0_DEF
    \
    \ @brief Channel/endpoint transmit buffer descriptor 0
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant USBSRAM_ADDR_TX                \ [0x00 : 16] Transmission buffer address
    $10 constant USBSRAM_COUNT_TX               \ [0x10 : 10] Transmission byte count
  [then]


  [ifdef] USBSRAM_USBSRAM_CHEP_TXRXBD_0_ALTERNATE1_DEF
    \
    \ @brief Channel/endpoint receive buffer descriptor 0
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant USBSRAM_ADDR_RX                \ [0x00 : 16] Reception buffer address
    $10 constant USBSRAM_COUNT_RX               \ [0x10 : 10] Reception byte count
    $1a constant USBSRAM_NUM_BLOCK              \ [0x1a : 5] Number of blocks
    $1f constant USBSRAM_BLSIZE                 \ [0x1f] Block size
  [then]


  [ifdef] USBSRAM_USBSRAM_CHEP_RXTXBD_0_DEF
    \
    \ @brief Channel/endpoint receive buffer descriptor 0
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant USBSRAM_ADDR_RX                \ [0x00 : 16] Reception buffer address
    $10 constant USBSRAM_COUNT_RX               \ [0x10 : 10] Reception byte count
    $1a constant USBSRAM_NUM_BLOCK              \ [0x1a : 5] Number of blocks
    $1f constant USBSRAM_BLSIZE                 \ [0x1f] Block size
  [then]


  [ifdef] USBSRAM_USBSRAM_CHEP_RXTXBD_0_ALTERNATE1_DEF
    \
    \ @brief Channel/endpoint transmit buffer descriptor 0
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant USBSRAM_ADDR_TX                \ [0x00 : 16] Transmission buffer address
    $10 constant USBSRAM_COUNT_TX               \ [0x10 : 10] Transmission byte count
  [then]


  [ifdef] USBSRAM_USBSRAM_CHEP_TXRXBD_1_DEF
    \
    \ @brief Channel/endpoint transmit buffer descriptor 1
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant USBSRAM_ADDR_TX                \ [0x00 : 16] Transmission buffer address
    $10 constant USBSRAM_COUNT_TX               \ [0x10 : 10] Transmission byte count
  [then]


  [ifdef] USBSRAM_USBSRAM_CHEP_TXRXBD_1_ALTERNATE1_DEF
    \
    \ @brief Channel/endpoint receive buffer descriptor 1
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant USBSRAM_ADDR_RX                \ [0x00 : 16] Reception buffer address
    $10 constant USBSRAM_COUNT_RX               \ [0x10 : 10] Reception byte count
    $1a constant USBSRAM_NUM_BLOCK              \ [0x1a : 5] Number of blocks
    $1f constant USBSRAM_BLSIZE                 \ [0x1f] Block size
  [then]


  [ifdef] USBSRAM_USBSRAM_CHEP_RXTXBD_1_DEF
    \
    \ @brief Channel/endpoint receive buffer descriptor 1
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant USBSRAM_ADDR_RX                \ [0x00 : 16] Reception buffer address
    $10 constant USBSRAM_COUNT_RX               \ [0x10 : 10] Reception byte count
    $1a constant USBSRAM_NUM_BLOCK              \ [0x1a : 5] Number of blocks
    $1f constant USBSRAM_BLSIZE                 \ [0x1f] Block size
  [then]


  [ifdef] USBSRAM_USBSRAM_CHEP_RXTXBD_1_ALTERNATE1_DEF
    \
    \ @brief Channel/endpoint transmit buffer descriptor 1
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant USBSRAM_ADDR_TX                \ [0x00 : 16] Transmission buffer address
    $10 constant USBSRAM_COUNT_TX               \ [0x10 : 10] Transmission byte count
  [then]


  [ifdef] USBSRAM_USBSRAM_CHEP_TXRXBD_2_DEF
    \
    \ @brief Channel/endpoint transmit buffer descriptor 2
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant USBSRAM_ADDR_TX                \ [0x00 : 16] Transmission buffer address
    $10 constant USBSRAM_COUNT_TX               \ [0x10 : 10] Transmission byte count
  [then]


  [ifdef] USBSRAM_USBSRAM_CHEP_TXRXBD_2_ALTERNATE1_DEF
    \
    \ @brief Channel/endpoint receive buffer descriptor 2
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant USBSRAM_ADDR_RX                \ [0x00 : 16] Reception buffer address
    $10 constant USBSRAM_COUNT_RX               \ [0x10 : 10] Reception byte count
    $1a constant USBSRAM_NUM_BLOCK              \ [0x1a : 5] Number of blocks
    $1f constant USBSRAM_BLSIZE                 \ [0x1f] Block size
  [then]


  [ifdef] USBSRAM_USBSRAM_CHEP_RXTXBD_2_DEF
    \
    \ @brief Channel/endpoint receive buffer descriptor 2
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant USBSRAM_ADDR_RX                \ [0x00 : 16] Reception buffer address
    $10 constant USBSRAM_COUNT_RX               \ [0x10 : 10] Reception byte count
    $1a constant USBSRAM_NUM_BLOCK              \ [0x1a : 5] Number of blocks
    $1f constant USBSRAM_BLSIZE                 \ [0x1f] Block size
  [then]


  [ifdef] USBSRAM_USBSRAM_CHEP_RXTXBD_2_ALTERNATE1_DEF
    \
    \ @brief Channel/endpoint transmit buffer descriptor 2
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant USBSRAM_ADDR_TX                \ [0x00 : 16] Transmission buffer address
    $10 constant USBSRAM_COUNT_TX               \ [0x10 : 10] Transmission byte count
  [then]


  [ifdef] USBSRAM_USBSRAM_CHEP_TXRXBD_3_DEF
    \
    \ @brief Channel/endpoint transmit buffer descriptor 3
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant USBSRAM_ADDR_TX                \ [0x00 : 16] Transmission buffer address
    $10 constant USBSRAM_COUNT_TX               \ [0x10 : 10] Transmission byte count
  [then]


  [ifdef] USBSRAM_USBSRAM_CHEP_TXRXBD_3_ALTERNATE1_DEF
    \
    \ @brief Channel/endpoint receive buffer descriptor 3
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant USBSRAM_ADDR_RX                \ [0x00 : 16] Reception buffer address
    $10 constant USBSRAM_COUNT_RX               \ [0x10 : 10] Reception byte count
    $1a constant USBSRAM_NUM_BLOCK              \ [0x1a : 5] Number of blocks
    $1f constant USBSRAM_BLSIZE                 \ [0x1f] Block size
  [then]


  [ifdef] USBSRAM_USBSRAM_CHEP_RXTXBD_3_DEF
    \
    \ @brief Channel/endpoint receive buffer descriptor 3
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant USBSRAM_ADDR_RX                \ [0x00 : 16] Reception buffer address
    $10 constant USBSRAM_COUNT_RX               \ [0x10 : 10] Reception byte count
    $1a constant USBSRAM_NUM_BLOCK              \ [0x1a : 5] Number of blocks
    $1f constant USBSRAM_BLSIZE                 \ [0x1f] Block size
  [then]


  [ifdef] USBSRAM_USBSRAM_CHEP_RXTXBD_3_ALTERNATE1_DEF
    \
    \ @brief Channel/endpoint transmit buffer descriptor 3
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant USBSRAM_ADDR_TX                \ [0x00 : 16] Transmission buffer address
    $10 constant USBSRAM_COUNT_TX               \ [0x10 : 10] Transmission byte count
  [then]


  [ifdef] USBSRAM_USBSRAM_CHEP_TXRXBD_4_DEF
    \
    \ @brief Channel/endpoint transmit buffer descriptor 4
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant USBSRAM_ADDR_TX                \ [0x00 : 16] Transmission buffer address
    $10 constant USBSRAM_COUNT_TX               \ [0x10 : 10] Transmission byte count
  [then]


  [ifdef] USBSRAM_USBSRAM_CHEP_TXRXBD_4_ALTERNATE1_DEF
    \
    \ @brief Channel/endpoint receive buffer descriptor 4
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant USBSRAM_ADDR_RX                \ [0x00 : 16] Reception buffer address
    $10 constant USBSRAM_COUNT_RX               \ [0x10 : 10] Reception byte count
    $1a constant USBSRAM_NUM_BLOCK              \ [0x1a : 5] Number of blocks
    $1f constant USBSRAM_BLSIZE                 \ [0x1f] Block size
  [then]


  [ifdef] USBSRAM_USBSRAM_CHEP_RXTXBD_4_DEF
    \
    \ @brief Channel/endpoint receive buffer descriptor 4
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant USBSRAM_ADDR_RX                \ [0x00 : 16] Reception buffer address
    $10 constant USBSRAM_COUNT_RX               \ [0x10 : 10] Reception byte count
    $1a constant USBSRAM_NUM_BLOCK              \ [0x1a : 5] Number of blocks
    $1f constant USBSRAM_BLSIZE                 \ [0x1f] Block size
  [then]


  [ifdef] USBSRAM_USBSRAM_CHEP_RXTXBD_4_ALTERNATE1_DEF
    \
    \ @brief Channel/endpoint transmit buffer descriptor 4
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant USBSRAM_ADDR_TX                \ [0x00 : 16] Transmission buffer address
    $10 constant USBSRAM_COUNT_TX               \ [0x10 : 10] Transmission byte count
  [then]


  [ifdef] USBSRAM_USBSRAM_CHEP_TXRXBD_5_DEF
    \
    \ @brief Channel/endpoint transmit buffer descriptor 5
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant USBSRAM_ADDR_TX                \ [0x00 : 16] Transmission buffer address
    $10 constant USBSRAM_COUNT_TX               \ [0x10 : 10] Transmission byte count
  [then]


  [ifdef] USBSRAM_USBSRAM_CHEP_TXRXBD_5_ALTERNATE1_DEF
    \
    \ @brief Channel/endpoint receive buffer descriptor 5
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant USBSRAM_ADDR_RX                \ [0x00 : 16] Reception buffer address
    $10 constant USBSRAM_COUNT_RX               \ [0x10 : 10] Reception byte count
    $1a constant USBSRAM_NUM_BLOCK              \ [0x1a : 5] Number of blocks
    $1f constant USBSRAM_BLSIZE                 \ [0x1f] Block size
  [then]


  [ifdef] USBSRAM_USBSRAM_CHEP_RXTXBD_5_DEF
    \
    \ @brief Channel/endpoint receive buffer descriptor 5
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant USBSRAM_ADDR_RX                \ [0x00 : 16] Reception buffer address
    $10 constant USBSRAM_COUNT_RX               \ [0x10 : 10] Reception byte count
    $1a constant USBSRAM_NUM_BLOCK              \ [0x1a : 5] Number of blocks
    $1f constant USBSRAM_BLSIZE                 \ [0x1f] Block size
  [then]


  [ifdef] USBSRAM_USBSRAM_CHEP_RXTXBD_5_ALTERNATE1_DEF
    \
    \ @brief Channel/endpoint transmit buffer descriptor 5
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant USBSRAM_ADDR_TX                \ [0x00 : 16] Transmission buffer address
    $10 constant USBSRAM_COUNT_TX               \ [0x10 : 10] Transmission byte count
  [then]


  [ifdef] USBSRAM_USBSRAM_CHEP_TXRXBD_6_DEF
    \
    \ @brief Channel/endpoint transmit buffer descriptor 6
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant USBSRAM_ADDR_TX                \ [0x00 : 16] Transmission buffer address
    $10 constant USBSRAM_COUNT_TX               \ [0x10 : 10] Transmission byte count
  [then]


  [ifdef] USBSRAM_USBSRAM_CHEP_TXRXBD_6_ALTERNATE1_DEF
    \
    \ @brief Channel/endpoint receive buffer descriptor 6
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant USBSRAM_ADDR_RX                \ [0x00 : 16] Reception buffer address
    $10 constant USBSRAM_COUNT_RX               \ [0x10 : 10] Reception byte count
    $1a constant USBSRAM_NUM_BLOCK              \ [0x1a : 5] Number of blocks
    $1f constant USBSRAM_BLSIZE                 \ [0x1f] Block size
  [then]


  [ifdef] USBSRAM_USBSRAM_CHEP_RXTXBD_6_DEF
    \
    \ @brief Channel/endpoint receive buffer descriptor 6
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant USBSRAM_ADDR_RX                \ [0x00 : 16] Reception buffer address
    $10 constant USBSRAM_COUNT_RX               \ [0x10 : 10] Reception byte count
    $1a constant USBSRAM_NUM_BLOCK              \ [0x1a : 5] Number of blocks
    $1f constant USBSRAM_BLSIZE                 \ [0x1f] Block size
  [then]


  [ifdef] USBSRAM_USBSRAM_CHEP_RXTXBD_6_ALTERNATE1_DEF
    \
    \ @brief Channel/endpoint transmit buffer descriptor 6
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant USBSRAM_ADDR_TX                \ [0x00 : 16] Transmission buffer address
    $10 constant USBSRAM_COUNT_TX               \ [0x10 : 10] Transmission byte count
  [then]


  [ifdef] USBSRAM_USBSRAM_CHEP_TXRXBD_7_DEF
    \
    \ @brief Channel/endpoint transmit buffer descriptor 7
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant USBSRAM_ADDR_TX                \ [0x00 : 16] Transmission buffer address
    $10 constant USBSRAM_COUNT_TX               \ [0x10 : 10] Transmission byte count
  [then]


  [ifdef] USBSRAM_USBSRAM_CHEP_TXRXBD_7_ALTERNATE1_DEF
    \
    \ @brief Channel/endpoint receive buffer descriptor 7
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant USBSRAM_ADDR_RX                \ [0x00 : 16] Reception buffer address
    $10 constant USBSRAM_COUNT_RX               \ [0x10 : 10] Reception byte count
    $1a constant USBSRAM_NUM_BLOCK              \ [0x1a : 5] Number of blocks
    $1f constant USBSRAM_BLSIZE                 \ [0x1f] Block size
  [then]


  [ifdef] USBSRAM_USBSRAM_CHEP_RXTXBD_7_DEF
    \
    \ @brief Channel/endpoint receive buffer descriptor 7
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant USBSRAM_ADDR_RX                \ [0x00 : 16] Reception buffer address
    $10 constant USBSRAM_COUNT_RX               \ [0x10 : 10] Reception byte count
    $1a constant USBSRAM_NUM_BLOCK              \ [0x1a : 5] Number of blocks
    $1f constant USBSRAM_BLSIZE                 \ [0x1f] Block size
  [then]


  [ifdef] USBSRAM_USBSRAM_CHEP_RXTXBD_7_ALTERNATE1_DEF
    \
    \ @brief Channel/endpoint transmit buffer descriptor 7
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant USBSRAM_ADDR_TX                \ [0x00 : 16] Transmission buffer address
    $10 constant USBSRAM_COUNT_TX               \ [0x10 : 10] Transmission byte count
  [then]

  \
  \ @brief USBSRAM address block description
  \
  $00 constant USBSRAM_USBSRAM_CHEP_TXRXBD_0    \ Channel/endpoint transmit buffer descriptor 0
  $00 constant USBSRAM_USBSRAM_CHEP_TXRXBD_0_ALTERNATE1    \ Channel/endpoint receive buffer descriptor 0
  $04 constant USBSRAM_USBSRAM_CHEP_RXTXBD_0    \ Channel/endpoint receive buffer descriptor 0
  $04 constant USBSRAM_USBSRAM_CHEP_RXTXBD_0_ALTERNATE1    \ Channel/endpoint transmit buffer descriptor 0
  $08 constant USBSRAM_USBSRAM_CHEP_TXRXBD_1    \ Channel/endpoint transmit buffer descriptor 1
  $08 constant USBSRAM_USBSRAM_CHEP_TXRXBD_1_ALTERNATE1    \ Channel/endpoint receive buffer descriptor 1
  $0C constant USBSRAM_USBSRAM_CHEP_RXTXBD_1    \ Channel/endpoint receive buffer descriptor 1
  $0C constant USBSRAM_USBSRAM_CHEP_RXTXBD_1_ALTERNATE1    \ Channel/endpoint transmit buffer descriptor 1
  $10 constant USBSRAM_USBSRAM_CHEP_TXRXBD_2    \ Channel/endpoint transmit buffer descriptor 2
  $10 constant USBSRAM_USBSRAM_CHEP_TXRXBD_2_ALTERNATE1    \ Channel/endpoint receive buffer descriptor 2
  $14 constant USBSRAM_USBSRAM_CHEP_RXTXBD_2    \ Channel/endpoint receive buffer descriptor 2
  $14 constant USBSRAM_USBSRAM_CHEP_RXTXBD_2_ALTERNATE1    \ Channel/endpoint transmit buffer descriptor 2
  $18 constant USBSRAM_USBSRAM_CHEP_TXRXBD_3    \ Channel/endpoint transmit buffer descriptor 3
  $18 constant USBSRAM_USBSRAM_CHEP_TXRXBD_3_ALTERNATE1    \ Channel/endpoint receive buffer descriptor 3
  $1C constant USBSRAM_USBSRAM_CHEP_RXTXBD_3    \ Channel/endpoint receive buffer descriptor 3
  $1C constant USBSRAM_USBSRAM_CHEP_RXTXBD_3_ALTERNATE1    \ Channel/endpoint transmit buffer descriptor 3
  $20 constant USBSRAM_USBSRAM_CHEP_TXRXBD_4    \ Channel/endpoint transmit buffer descriptor 4
  $20 constant USBSRAM_USBSRAM_CHEP_TXRXBD_4_ALTERNATE1    \ Channel/endpoint receive buffer descriptor 4
  $24 constant USBSRAM_USBSRAM_CHEP_RXTXBD_4    \ Channel/endpoint receive buffer descriptor 4
  $24 constant USBSRAM_USBSRAM_CHEP_RXTXBD_4_ALTERNATE1    \ Channel/endpoint transmit buffer descriptor 4
  $28 constant USBSRAM_USBSRAM_CHEP_TXRXBD_5    \ Channel/endpoint transmit buffer descriptor 5
  $28 constant USBSRAM_USBSRAM_CHEP_TXRXBD_5_ALTERNATE1    \ Channel/endpoint receive buffer descriptor 5
  $2C constant USBSRAM_USBSRAM_CHEP_RXTXBD_5    \ Channel/endpoint receive buffer descriptor 5
  $2C constant USBSRAM_USBSRAM_CHEP_RXTXBD_5_ALTERNATE1    \ Channel/endpoint transmit buffer descriptor 5
  $30 constant USBSRAM_USBSRAM_CHEP_TXRXBD_6    \ Channel/endpoint transmit buffer descriptor 6
  $30 constant USBSRAM_USBSRAM_CHEP_TXRXBD_6_ALTERNATE1    \ Channel/endpoint receive buffer descriptor 6
  $34 constant USBSRAM_USBSRAM_CHEP_RXTXBD_6    \ Channel/endpoint receive buffer descriptor 6
  $34 constant USBSRAM_USBSRAM_CHEP_RXTXBD_6_ALTERNATE1    \ Channel/endpoint transmit buffer descriptor 6
  $38 constant USBSRAM_USBSRAM_CHEP_TXRXBD_7    \ Channel/endpoint transmit buffer descriptor 7
  $38 constant USBSRAM_USBSRAM_CHEP_TXRXBD_7_ALTERNATE1    \ Channel/endpoint receive buffer descriptor 7
  $3C constant USBSRAM_USBSRAM_CHEP_RXTXBD_7    \ Channel/endpoint receive buffer descriptor 7
  $3C constant USBSRAM_USBSRAM_CHEP_RXTXBD_7_ALTERNATE1    \ Channel/endpoint transmit buffer descriptor 7

: USBSRAM_DEF ; [then]
