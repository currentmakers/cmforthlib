\
\ @file usb.fs
\ @brief Universal serial bus full-speed device interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] USB_DEF

  [ifdef] USB_EP0R_DEF
    \
    \ @brief endpoint 0 register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant USB_EA                         \ [0x00 : 4] Endpoint address
    $04 constant USB_STAT_TX                    \ [0x04 : 2] Status bits, for transmission transfers
    $06 constant USB_DTOG_TX                    \ [0x06] Data Toggle, for transmission transfers
    $07 constant USB_CTR_TX                     \ [0x07] Correct Transfer for transmission
    $08 constant USB_EP_KIND                    \ [0x08] Endpoint kind
    $09 constant USB_EP_TYPE                    \ [0x09 : 2] Endpoint type
    $0b constant USB_SETUP                      \ [0x0b] Setup transaction completed
    $0c constant USB_STAT_RX                    \ [0x0c : 2] Status bits, for reception transfers
    $0e constant USB_DTOG_RX                    \ [0x0e] Data Toggle, for reception transfers
    $0f constant USB_CTR_RX                     \ [0x0f] Correct transfer for reception
  [then]


  [ifdef] USB_EP1R_DEF
    \
    \ @brief endpoint 1 register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant USB_EA                         \ [0x00 : 4] Endpoint address
    $04 constant USB_STAT_TX                    \ [0x04 : 2] Status bits, for transmission transfers
    $06 constant USB_DTOG_TX                    \ [0x06] Data Toggle, for transmission transfers
    $07 constant USB_CTR_TX                     \ [0x07] Correct Transfer for transmission
    $08 constant USB_EP_KIND                    \ [0x08] Endpoint kind
    $09 constant USB_EP_TYPE                    \ [0x09 : 2] Endpoint type
    $0b constant USB_SETUP                      \ [0x0b] Setup transaction completed
    $0c constant USB_STAT_RX                    \ [0x0c : 2] Status bits, for reception transfers
    $0e constant USB_DTOG_RX                    \ [0x0e] Data Toggle, for reception transfers
    $0f constant USB_CTR_RX                     \ [0x0f] Correct transfer for reception
  [then]


  [ifdef] USB_EP2R_DEF
    \
    \ @brief endpoint 2 register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant USB_EA                         \ [0x00 : 4] Endpoint address
    $04 constant USB_STAT_TX                    \ [0x04 : 2] Status bits, for transmission transfers
    $06 constant USB_DTOG_TX                    \ [0x06] Data Toggle, for transmission transfers
    $07 constant USB_CTR_TX                     \ [0x07] Correct Transfer for transmission
    $08 constant USB_EP_KIND                    \ [0x08] Endpoint kind
    $09 constant USB_EP_TYPE                    \ [0x09 : 2] Endpoint type
    $0b constant USB_SETUP                      \ [0x0b] Setup transaction completed
    $0c constant USB_STAT_RX                    \ [0x0c : 2] Status bits, for reception transfers
    $0e constant USB_DTOG_RX                    \ [0x0e] Data Toggle, for reception transfers
    $0f constant USB_CTR_RX                     \ [0x0f] Correct transfer for reception
  [then]


  [ifdef] USB_EP3R_DEF
    \
    \ @brief endpoint 3 register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant USB_EA                         \ [0x00 : 4] Endpoint address
    $04 constant USB_STAT_TX                    \ [0x04 : 2] Status bits, for transmission transfers
    $06 constant USB_DTOG_TX                    \ [0x06] Data Toggle, for transmission transfers
    $07 constant USB_CTR_TX                     \ [0x07] Correct Transfer for transmission
    $08 constant USB_EP_KIND                    \ [0x08] Endpoint kind
    $09 constant USB_EP_TYPE                    \ [0x09 : 2] Endpoint type
    $0b constant USB_SETUP                      \ [0x0b] Setup transaction completed
    $0c constant USB_STAT_RX                    \ [0x0c : 2] Status bits, for reception transfers
    $0e constant USB_DTOG_RX                    \ [0x0e] Data Toggle, for reception transfers
    $0f constant USB_CTR_RX                     \ [0x0f] Correct transfer for reception
  [then]


  [ifdef] USB_EP4R_DEF
    \
    \ @brief endpoint 4 register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant USB_EA                         \ [0x00 : 4] Endpoint address
    $04 constant USB_STAT_TX                    \ [0x04 : 2] Status bits, for transmission transfers
    $06 constant USB_DTOG_TX                    \ [0x06] Data Toggle, for transmission transfers
    $07 constant USB_CTR_TX                     \ [0x07] Correct Transfer for transmission
    $08 constant USB_EP_KIND                    \ [0x08] Endpoint kind
    $09 constant USB_EP_TYPE                    \ [0x09 : 2] Endpoint type
    $0b constant USB_SETUP                      \ [0x0b] Setup transaction completed
    $0c constant USB_STAT_RX                    \ [0x0c : 2] Status bits, for reception transfers
    $0e constant USB_DTOG_RX                    \ [0x0e] Data Toggle, for reception transfers
    $0f constant USB_CTR_RX                     \ [0x0f] Correct transfer for reception
  [then]


  [ifdef] USB_EP5R_DEF
    \
    \ @brief endpoint 5 register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant USB_EA                         \ [0x00 : 4] Endpoint address
    $04 constant USB_STAT_TX                    \ [0x04 : 2] Status bits, for transmission transfers
    $06 constant USB_DTOG_TX                    \ [0x06] Data Toggle, for transmission transfers
    $07 constant USB_CTR_TX                     \ [0x07] Correct Transfer for transmission
    $08 constant USB_EP_KIND                    \ [0x08] Endpoint kind
    $09 constant USB_EP_TYPE                    \ [0x09 : 2] Endpoint type
    $0b constant USB_SETUP                      \ [0x0b] Setup transaction completed
    $0c constant USB_STAT_RX                    \ [0x0c : 2] Status bits, for reception transfers
    $0e constant USB_DTOG_RX                    \ [0x0e] Data Toggle, for reception transfers
    $0f constant USB_CTR_RX                     \ [0x0f] Correct transfer for reception
  [then]


  [ifdef] USB_EP6R_DEF
    \
    \ @brief endpoint 6 register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant USB_EA                         \ [0x00 : 4] Endpoint address
    $04 constant USB_STAT_TX                    \ [0x04 : 2] Status bits, for transmission transfers
    $06 constant USB_DTOG_TX                    \ [0x06] Data Toggle, for transmission transfers
    $07 constant USB_CTR_TX                     \ [0x07] Correct Transfer for transmission
    $08 constant USB_EP_KIND                    \ [0x08] Endpoint kind
    $09 constant USB_EP_TYPE                    \ [0x09 : 2] Endpoint type
    $0b constant USB_SETUP                      \ [0x0b] Setup transaction completed
    $0c constant USB_STAT_RX                    \ [0x0c : 2] Status bits, for reception transfers
    $0e constant USB_DTOG_RX                    \ [0x0e] Data Toggle, for reception transfers
    $0f constant USB_CTR_RX                     \ [0x0f] Correct transfer for reception
  [then]


  [ifdef] USB_EP7R_DEF
    \
    \ @brief endpoint 7 register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant USB_EA                         \ [0x00 : 4] Endpoint address
    $04 constant USB_STAT_TX                    \ [0x04 : 2] Status bits, for transmission transfers
    $06 constant USB_DTOG_TX                    \ [0x06] Data Toggle, for transmission transfers
    $07 constant USB_CTR_TX                     \ [0x07] Correct Transfer for transmission
    $08 constant USB_EP_KIND                    \ [0x08] Endpoint kind
    $09 constant USB_EP_TYPE                    \ [0x09 : 2] Endpoint type
    $0b constant USB_SETUP                      \ [0x0b] Setup transaction completed
    $0c constant USB_STAT_RX                    \ [0x0c : 2] Status bits, for reception transfers
    $0e constant USB_DTOG_RX                    \ [0x0e] Data Toggle, for reception transfers
    $0f constant USB_CTR_RX                     \ [0x0f] Correct transfer for reception
  [then]


  [ifdef] USB_CNTR_DEF
    \
    \ @brief control register
    \ Address offset: 0x40
    \ Reset value: 0x00000003
    \
    $00 constant USB_FRES                       \ [0x00] Force USB Reset
    $01 constant USB_PDWN                       \ [0x01] Power down
    $02 constant USB_LPMODE                     \ [0x02] Low-power mode
    $03 constant USB_FSUSP                      \ [0x03] Force suspend
    $04 constant USB_RESUME                     \ [0x04] Resume request
    $05 constant USB_L1RESUME                   \ [0x05] LPM L1 Resume request
    $07 constant USB_L1REQM                     \ [0x07] LPM L1 state request interrupt mask
    $08 constant USB_ESOFM                      \ [0x08] Expected start of frame interrupt mask
    $09 constant USB_SOFM                       \ [0x09] Start of frame interrupt mask
    $0a constant USB_RESETM                     \ [0x0a] USB reset interrupt mask
    $0b constant USB_SUSPM                      \ [0x0b] Suspend mode interrupt mask
    $0c constant USB_WKUPM                      \ [0x0c] Wakeup interrupt mask
    $0d constant USB_ERRM                       \ [0x0d] Error interrupt mask
    $0e constant USB_PMAOVRM                    \ [0x0e] Packet memory area over / underrun interrupt mask
    $0f constant USB_CTRM                       \ [0x0f] Correct transfer interrupt mask
  [then]


  [ifdef] USB_ISTR_DEF
    \
    \ @brief interrupt status register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant USB_EP_ID                      \ [0x00 : 4] Endpoint Identifier
    $04 constant USB_DIR                        \ [0x04] Direction of transaction
    $07 constant USB_L1REQ                      \ [0x07] LPM L1 state request
    $08 constant USB_ESOF                       \ [0x08] Expected start frame
    $09 constant USB_SOF                        \ [0x09] start of frame
    $0a constant USB_RESET                      \ [0x0a] reset request
    $0b constant USB_SUSP                       \ [0x0b] Suspend mode request
    $0c constant USB_WKUP                       \ [0x0c] Wakeup
    $0d constant USB_ERR                        \ [0x0d] Error
    $0e constant USB_PMAOVR                     \ [0x0e] Packet memory area over / underrun
    $0f constant USB_CTR                        \ [0x0f] Correct transfer
  [then]


  [ifdef] USB_FNR_DEF
    \
    \ @brief frame number register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant USB_FN                         \ [0x00 : 11] Frame number
    $0b constant USB_LSOF                       \ [0x0b : 2] Lost SOF
    $0d constant USB_LCK                        \ [0x0d] Locked
    $0e constant USB_RXDM                       \ [0x0e] Receive data - line status
    $0f constant USB_RXDP                       \ [0x0f] Receive data + line status
  [then]


  [ifdef] USB_DADDR_DEF
    \
    \ @brief device address
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant USB_ADD                        \ [0x00 : 7] Device address
    $07 constant USB_EF                         \ [0x07] Enable function
  [then]


  [ifdef] USB_BTABLE_DEF
    \
    \ @brief Buffer table address
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $03 constant USB_BTABLE                     \ [0x03 : 13] Buffer table
  [then]


  [ifdef] USB_COUNT0_TX_DEF
    \
    \ @brief Transmission byte count 0
    \ Address offset: 0x52
    \ Reset value: 0x00000000
    \
    $00 constant USB_COUNT0_TX                  \ [0x00 : 10] Transmission byte count
  [then]


  [ifdef] USB_LPMCSR_DEF
    \
    \ @brief LPM control and status register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant USB_LPMEN                      \ [0x00] LPM support enable
    $01 constant USB_LPMACK                     \ [0x01] LPM Token acknowledge enable
    $03 constant USB_REMWAKE                    \ [0x03] RemoteWake value
    $04 constant USB_BESL                       \ [0x04 : 4] BESL value
  [then]


  [ifdef] USB_ADDR0_RX_DEF
    \
    \ @brief Reception buffer address 0
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $01 constant USB_ADDR0_RX                   \ [0x01 : 15] Reception buffer address
  [then]


  [ifdef] USB_COUNT0_RX_DEF
    \
    \ @brief Reception byte count 0
    \ Address offset: 0x56
    \ Reset value: 0x00000000
    \
    $00 constant USB_COUNT0_RX                  \ [0x00 : 10] Reception byte count
    $0a constant USB_NUM_BLOCK                  \ [0x0a : 5] Number of blocks
    $0f constant USB_BL_SIZE                    \ [0x0f] Block size
  [then]


  [ifdef] USB_BCDR_DEF
    \
    \ @brief Battery charging detector
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant USB_BCDEN                      \ [0x00] Battery charging detector (BCD) enable
    $01 constant USB_DCDEN                      \ [0x01] Data contact detection (DCD) mode enable
    $02 constant USB_PDEN                       \ [0x02] Primary detection (PD) mode enable
    $03 constant USB_SDEN                       \ [0x03] Secondary detection (SD) mode enable
    $04 constant USB_DCDET                      \ [0x04] Data contact detection (DCD) status
    $05 constant USB_PDET                       \ [0x05] Primary detection (PD) status
    $06 constant USB_SDET                       \ [0x06] Secondary detection (SD) status
    $07 constant USB_PS2DET                     \ [0x07] DM pull-up detection status
    $0f constant USB_DPPU                       \ [0x0f] DP pull-up control
  [then]


  [ifdef] USB_COUNT1_TX_DEF
    \
    \ @brief Transmission byte count 0
    \ Address offset: 0x5A
    \ Reset value: 0x00000000
    \
    $00 constant USB_COUNT1_TX                  \ [0x00 : 10] Transmission byte count
  [then]


  [ifdef] USB_ADDR1_RX_DEF
    \
    \ @brief Reception buffer address 0
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $01 constant USB_ADDR1_RX                   \ [0x01 : 15] Reception buffer address
  [then]


  [ifdef] USB_COUNT1_RX_DEF
    \
    \ @brief Reception byte count 0
    \ Address offset: 0x5E
    \ Reset value: 0x00000000
    \
    $00 constant USB_COUNT1_RX                  \ [0x00 : 10] Reception byte count
    $0a constant USB_NUM_BLOCK                  \ [0x0a : 5] Number of blocks
    $0f constant USB_BL_SIZE                    \ [0x0f] Block size
  [then]


  [ifdef] USB_ADDR2_TX_DEF
    \
    \ @brief Transmission buffer address 2
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $01 constant USB_ADDR2_TX                   \ [0x01 : 15] Transmission buffer address
  [then]


  [ifdef] USB_COUNT2_TX_DEF
    \
    \ @brief Transmission byte count 0
    \ Address offset: 0x62
    \ Reset value: 0x00000000
    \
    $00 constant USB_COUNT2_TX                  \ [0x00 : 10] Transmission byte count
  [then]


  [ifdef] USB_ADDR2_RX_DEF
    \
    \ @brief Reception buffer address 0
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $01 constant USB_ADDR2_RX                   \ [0x01 : 15] Reception buffer address
  [then]


  [ifdef] USB_COUNT2_RX_DEF
    \
    \ @brief Reception byte count 0
    \ Address offset: 0x66
    \ Reset value: 0x00000000
    \
    $00 constant USB_COUNT2_RX                  \ [0x00 : 10] Reception byte count
    $0a constant USB_NUM_BLOCK                  \ [0x0a : 5] Number of blocks
    $0f constant USB_BL_SIZE                    \ [0x0f] Block size
  [then]


  [ifdef] USB_ADDR3_TX_DEF
    \
    \ @brief Transmission buffer address 3
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $01 constant USB_ADDR3_TX                   \ [0x01 : 15] Transmission buffer address
  [then]


  [ifdef] USB_COUNT3_TX_DEF
    \
    \ @brief Transmission byte count 0
    \ Address offset: 0x6A
    \ Reset value: 0x00000000
    \
    $00 constant USB_COUNT3_TX                  \ [0x00 : 10] Transmission byte count
  [then]


  [ifdef] USB_ADDR3_RX_DEF
    \
    \ @brief Reception buffer address 0
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $01 constant USB_ADDR3_RX                   \ [0x01 : 15] Reception buffer address
  [then]


  [ifdef] USB_COUNT3_RX_DEF
    \
    \ @brief Reception byte count 0
    \ Address offset: 0x6E
    \ Reset value: 0x00000000
    \
    $00 constant USB_COUNT3_RX                  \ [0x00 : 10] Reception byte count
    $0a constant USB_NUM_BLOCK                  \ [0x0a : 5] Number of blocks
    $0f constant USB_BL_SIZE                    \ [0x0f] Block size
  [then]


  [ifdef] USB_ADDR4_TX_DEF
    \
    \ @brief Transmission buffer address 0
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $01 constant USB_ADDR4_RX                   \ [0x01 : 15] Transmission buffer address
  [then]


  [ifdef] USB_COUNT4_TX_DEF
    \
    \ @brief Transmission byte count 0
    \ Address offset: 0x72
    \ Reset value: 0x00000000
    \
    $00 constant USB_COUNT4_TX                  \ [0x00 : 10] Transmission byte count
  [then]


  [ifdef] USB_ADDR4_RX_DEF
    \
    \ @brief Reception buffer address 0
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $01 constant USB_ADDR4_RX                   \ [0x01 : 15] Reception buffer address
  [then]


  [ifdef] USB_COUNT4_RX_DEF
    \
    \ @brief Reception byte count 0
    \ Address offset: 0x76
    \ Reset value: 0x00000000
    \
    $00 constant USB_COUNT4_RX                  \ [0x00 : 10] Reception byte count
    $0a constant USB_NUM_BLOCK                  \ [0x0a : 5] Number of blocks
    $0f constant USB_BL_SIZE                    \ [0x0f] Block size
  [then]


  [ifdef] USB_ADDR5_TX_DEF
    \
    \ @brief Transmission buffer address 0
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $01 constant USB_ADDR5_TX                   \ [0x01 : 15] Transmission buffer address
  [then]


  [ifdef] USB_COUNT5_TX_DEF
    \
    \ @brief Transmission byte count 0
    \ Address offset: 0x7A
    \ Reset value: 0x00000000
    \
    $00 constant USB_COUNT5_TX                  \ [0x00 : 10] Transmission byte count
  [then]


  [ifdef] USB_ADDR5_RX_DEF
    \
    \ @brief Reception buffer address 0
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $01 constant USB_ADDR5_RX                   \ [0x01 : 15] Reception buffer address
  [then]


  [ifdef] USB_COUNT5_RX_DEF
    \
    \ @brief Reception byte count 0
    \ Address offset: 0x7E
    \ Reset value: 0x00000000
    \
    $00 constant USB_COUNT5_RX                  \ [0x00 : 10] Reception byte count
    $0a constant USB_NUM_BLOCK                  \ [0x0a : 5] Number of blocks
    $0f constant USB_BL_SIZE                    \ [0x0f] Block size
  [then]


  [ifdef] USB_ADDR6_TX_DEF
    \
    \ @brief Transmission buffer address 0
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $01 constant USB_ADDR6_TX                   \ [0x01 : 15] Transmission buffer address
  [then]


  [ifdef] USB_COUNT6_TX_DEF
    \
    \ @brief Transmission byte count 0
    \ Address offset: 0x82
    \ Reset value: 0x00000000
    \
    $00 constant USB_COUNT6_TX                  \ [0x00 : 10] Transmission byte count
  [then]


  [ifdef] USB_ADDR6_RX_DEF
    \
    \ @brief Reception buffer address 0
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $01 constant USB_ADDR6_RX                   \ [0x01 : 15] Reception buffer address
  [then]


  [ifdef] USB_COUNT6_RX_DEF
    \
    \ @brief Reception byte count 0
    \ Address offset: 0x86
    \ Reset value: 0x00000000
    \
    $00 constant USB_COUNT6_RX                  \ [0x00 : 10] Reception byte count
    $0a constant USB_NUM_BLOCK                  \ [0x0a : 5] Number of blocks
    $0f constant USB_BL_SIZE                    \ [0x0f] Block size
  [then]


  [ifdef] USB_ADDR7_TX_DEF
    \
    \ @brief Transmission buffer address 0
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $01 constant USB_ADDR7_TX                   \ [0x01 : 15] Transmission buffer address
  [then]


  [ifdef] USB_COUNT7_TX_DEF
    \
    \ @brief Transmission byte count 0
    \ Address offset: 0x8A
    \ Reset value: 0x00000000
    \
    $00 constant USB_COUNT7_TX                  \ [0x00 : 10] Transmission byte count
  [then]


  [ifdef] USB_ADDR7_RX_DEF
    \
    \ @brief Reception buffer address 0
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $01 constant USB_ADDR7_RX                   \ [0x01 : 15] Reception buffer address
  [then]


  [ifdef] USB_COUNT7_RX_DEF
    \
    \ @brief Reception byte count 0
    \ Address offset: 0x8E
    \ Reset value: 0x00000000
    \
    $00 constant USB_COUNT7_RX                  \ [0x00 : 10] Reception byte count
    $0a constant USB_NUM_BLOCK                  \ [0x0a : 5] Number of blocks
    $0f constant USB_BL_SIZE                    \ [0x0f] Block size
  [then]

  \
  \ @brief Universal serial bus full-speed device interface
  \
  $00 constant USB_EP0R                 \ endpoint 0 register
  $04 constant USB_EP1R                 \ endpoint 1 register
  $08 constant USB_EP2R                 \ endpoint 2 register
  $0C constant USB_EP3R                 \ endpoint 3 register
  $10 constant USB_EP4R                 \ endpoint 4 register
  $14 constant USB_EP5R                 \ endpoint 5 register
  $18 constant USB_EP6R                 \ endpoint 6 register
  $1C constant USB_EP7R                 \ endpoint 7 register
  $40 constant USB_CNTR                 \ control register
  $44 constant USB_ISTR                 \ interrupt status register
  $48 constant USB_FNR                  \ frame number register
  $4C constant USB_DADDR                \ device address
  $50 constant USB_BTABLE               \ Buffer table address
  $52 constant USB_COUNT0_TX            \ Transmission byte count 0
  $54 constant USB_LPMCSR               \ LPM control and status register
  $54 constant USB_ADDR0_RX             \ Reception buffer address 0
  $56 constant USB_COUNT0_RX            \ Reception byte count 0
  $58 constant USB_BCDR                 \ Battery charging detector
  $5A constant USB_COUNT1_TX            \ Transmission byte count 0
  $5C constant USB_ADDR1_RX             \ Reception buffer address 0
  $5E constant USB_COUNT1_RX            \ Reception byte count 0
  $60 constant USB_ADDR2_TX             \ Transmission buffer address 2
  $62 constant USB_COUNT2_TX            \ Transmission byte count 0
  $64 constant USB_ADDR2_RX             \ Reception buffer address 0
  $66 constant USB_COUNT2_RX            \ Reception byte count 0
  $68 constant USB_ADDR3_TX             \ Transmission buffer address 3
  $6A constant USB_COUNT3_TX            \ Transmission byte count 0
  $6C constant USB_ADDR3_RX             \ Reception buffer address 0
  $6E constant USB_COUNT3_RX            \ Reception byte count 0
  $70 constant USB_ADDR4_TX             \ Transmission buffer address 0
  $72 constant USB_COUNT4_TX            \ Transmission byte count 0
  $74 constant USB_ADDR4_RX             \ Reception buffer address 0
  $76 constant USB_COUNT4_RX            \ Reception byte count 0
  $78 constant USB_ADDR5_TX             \ Transmission buffer address 0
  $7A constant USB_COUNT5_TX            \ Transmission byte count 0
  $7C constant USB_ADDR5_RX             \ Reception buffer address 0
  $7E constant USB_COUNT5_RX            \ Reception byte count 0
  $80 constant USB_ADDR6_TX             \ Transmission buffer address 0
  $82 constant USB_COUNT6_TX            \ Transmission byte count 0
  $84 constant USB_ADDR6_RX             \ Reception buffer address 0
  $86 constant USB_COUNT6_RX            \ Reception byte count 0
  $88 constant USB_ADDR7_TX             \ Transmission buffer address 0
  $8A constant USB_COUNT7_TX            \ Transmission byte count 0
  $8C constant USB_ADDR7_RX             \ Reception buffer address 0
  $8E constant USB_COUNT7_RX            \ Reception byte count 0

: USB_DEF ; [then]
