\
\ @file flash_ctrl.fs
\ @brief 4kb addressable space
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] FLASH_CTRL_DEF

  [ifdef] FLASH_CTRL_COMMAND_DEF
    \
    \ @brief COMMAND register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_CTRL_COMMAND             \ [0x00 : 8] Macro commands for flash operations (may require DATA0...DATA3 to be set): - 0x11 : ERASE - 0x22 : MASSERASE - 0x33 : WRITE - 0x55 : MASSREAD - 0xAA : SLEEP - 0xBB : WAKEUP - 0xCC : BURSTWRITE - 0xEE : OTPWRITE - 0xFF : KEYWRITE
  [then]


  [ifdef] FLASH_CTRL_CONFIG_DEF
    \
    \ @brief CONFIG register
    \ Address offset: 0x04
    \ Reset value: 0x00000010
    \
    $01 constant FLASH_CTRL_REMAP               \ [0x01] CPU access routing (it supersedes PREMAP configuration): - 0 : FLASH memory addressed - 1 : SRAM0 memory addressed
    $02 constant FLASH_CTRL_DIS_GROUP_WRITE     \ [0x02] Burst write Control: - 0 : burst write allowed - 1 : burst write forbidden
    $04 constant FLASH_CTRL_WAIT_STATE          \ [0x04 : 2] Add latency to flash read opeations: - 00 : no latency - 01 : 1 clock cycle latency - 10 : 2 clock cycles latency - 11 : 3 clock cycles latency
  [then]


  [ifdef] FLASH_CTRL_IRQSTAT_DEF
    \
    \ @brief IRQSTAT register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_CTRL_CMDDONE_MIS         \ [0x00] (1: clear, 0: inactive) CMDDONE_MIS flag
    $01 constant FLASH_CTRL_CMDSTART_MIS        \ [0x01] (1: clear, 0: inactive) CMDSTART_MIS flag
    $02 constant FLASH_CTRL_CMDBUSYERR_MIS      \ [0x02] (1: clear, 0: inactive) CMDBUSYERR_MIS flag
    $03 constant FLASH_CTRL_ILLCMD_MIS          \ [0x03] (1: clear, 0: inactive) ILLCMD_MIS flag
    $04 constant FLASH_CTRL_READOK_MIS          \ [0x04] (1: clear, 0: inactive) READOK_MIS flag
    $05 constant FLASH_CTRL_FNREADY_MIS         \ [0x05] (1: clear, 0: inactive) FNREADY_MIS flag
  [then]


  [ifdef] FLASH_CTRL_IRQMASK_DEF
    \
    \ @brief IRQMASK register
    \ Address offset: 0x0C
    \ Reset value: 0x0000003F
    \
    $00 constant FLASH_CTRL_CMDDONEM            \ [0x00] (1: mask, 0: inactive) CMDDONE_MIS mask
    $01 constant FLASH_CTRL_CMDSTARTM           \ [0x01] (1: mask, 0: inactive) CMDSTART_MIS mask
    $02 constant FLASH_CTRL_CMDBUSYERRM         \ [0x02] (1: mask, 0: inactive) CMDBUSYERR_MIS mask
    $03 constant FLASH_CTRL_ILLCMDM             \ [0x03] (1: mask, 0: inactive) ILLCMD_MIS mask
    $04 constant FLASH_CTRL_READOKM             \ [0x04] (1: mask, 0: inactive) READOK_MIS mask
    $05 constant FLASH_CTRL_FNREADYM            \ [0x05] (1: mask, 0: inactive) FNREADY_MIS mask
  [then]


  [ifdef] FLASH_CTRL_IRQRAW_DEF
    \
    \ @brief IRQRAW register
    \ Address offset: 0x10
    \ Reset value: 0x00000001
    \
    $00 constant FLASH_CTRL_CMDDONE_RIS         \ [0x00] (1: active, 0: inactive) COMMAND sequence ended
    $01 constant FLASH_CTRL_CMDSTART_RIS        \ [0x01] (1: active, 0: inactive) COMMAND sequence started
    $02 constant FLASH_CTRL_CMDBUSYERR_RIS      \ [0x02] (1: active, 0: inactive) COMMAND issued while flash busy
    $03 constant FLASH_CTRL_ILLCMD_RIS          \ [0x03] (1: active, 0: inactive) Illegal command issued
    $04 constant FLASH_CTRL_READOK_RIS          \ [0x04] (1: active, 0: inactive) READ COMMAND completed successfully
    $05 constant FLASH_CTRL_CMDSLEEPERR_RIS     \ [0x05] (1: active, 0: inactive) COMMAND issued while flash in sleep-mode (SLM=1)
  [then]


  [ifdef] FLASH_CTRL_SIZE_DEF
    \
    \ @brief SIZE register
    \ Address offset: 0x14
    \ Reset value: 0x0006BFFF
    \
    $00 constant FLASH_CTRL_FLASH_SIZE          \ [0x00 : 17] Maximum valid address for flash memory: - 00 : 0x03FFF (64kb) - 01 : 0x07FFF (128kb) - 10 : 0x09FFF (160kb) - 11 : 0x0BFFF (192kb)
    $11 constant FLASH_CTRL_RAM_SIZE            \ [0x11] RAM memory size selection: - 0 : 16kb - 1 : 32kb
    $13 constant FLASH_CTRL_FLASH_SECURE        \ [0x13] Flash memory protection (0: no key present, 1: key present)
    $14 constant FLASH_CTRL_JTAG_DISABLE        \ [0x14] Flash+JTAG protection (0: no JTAG protection - see FLASH_SECURE, 1: Flash and JTAG protected)
    $15 constant FLASH_CTRL_PACKAGE_SIZE        \ [0x15 : 2] Package selection: - 0- : CSP - 10 : 32pins - 11 : 48pins
  [then]


  [ifdef] FLASH_CTRL_ADDRESS_DEF
    \
    \ @brief ADDRESS register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_CTRL_YADDR               \ [0x00 : 6] Flash column address offset to be used with some COMMAND
    $06 constant FLASH_CTRL_XADDR               \ [0x06 : 10] Flash row address offset to be used with some COMMAND
  [then]


  [ifdef] FLASH_CTRL_LFSRVAL_DEF
    \
    \ @brief LFSRVAL register
    \ Address offset: 0x24
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant FLASH_CTRL_LFSRVAL             \ [0x00 : 32] Flash read data CRC signature
  [then]


  [ifdef] FLASH_CTRL_PAGEPROT0_DEF
    \
    \ @brief PAGEPROT0 register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_CTRL_SEGSIZE0            \ [0x00 : 7] First segment, 7-bit page protection size (number of pages to protect in segment, first page included)
    $08 constant FLASH_CTRL_SEGOFFSET0          \ [0x08 : 7] First segment, 7-bit page protection offset (first page number in protected segment)
    $10 constant FLASH_CTRL_SEGSIZE1            \ [0x10 : 7] Second segment, 7-bit page protection size (number of pages to protect in segment, first page included)
    $18 constant FLASH_CTRL_SEGOFFSET1          \ [0x18 : 7] Second segment, 7-bit page protection offset (first page number in protected segment)
  [then]


  [ifdef] FLASH_CTRL_PAGEPROT1_DEF
    \
    \ @brief PAGEPROT1 register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_CTRL_SEGSIZE2            \ [0x00 : 7] Third segment, 7-bit page protection size (number of pages to protect in segment, first page included)
    $08 constant FLASH_CTRL_SEGOFFSET2          \ [0x08 : 7] Third segment, 7-bit page protection offset (first page number in protected segment)
    $10 constant FLASH_CTRL_SEGSIZE3            \ [0x10 : 7] Fourth segment, 7-bit page protection size (number of pages to protect in segment, first page included)
    $18 constant FLASH_CTRL_SEGOFFSET3          \ [0x18 : 7] Fourth segment, 7-bit page protection offset (first page number in protected segment)
  [then]


  [ifdef] FLASH_CTRL_DATA0_DEF
    \
    \ @brief DATA0 register
    \ Address offset: 0x40
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant FLASH_CTRL_DATA0               \ [0x00 : 32] Value to be used as DATA for any COMMAND of type WRITE and compare value for MASSREAD
  [then]


  [ifdef] FLASH_CTRL_DATA1_DEF
    \
    \ @brief DATA1 register
    \ Address offset: 0x44
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant FLASH_CTRL_DATA1               \ [0x00 : 32] Value to be used as DATA for any COMMAND of type WRITE
  [then]


  [ifdef] FLASH_CTRL_DATA2_DEF
    \
    \ @brief DATA2 register
    \ Address offset: 0x48
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant FLASH_CTRL_DATA2               \ [0x00 : 32] Value to be used as DATA for any COMMAND of type WRITE
  [then]


  [ifdef] FLASH_CTRL_DATA3_DEF
    \
    \ @brief DATA3 register
    \ Address offset: 0x4C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant FLASH_CTRL_DATA3               \ [0x00 : 32] Value to be used as DATA for any COMMAND of type WRITE
  [then]

  \
  \ @brief 4kb addressable space
  \
  $00 constant FLASH_CTRL_COMMAND       \ COMMAND register
  $04 constant FLASH_CTRL_CONFIG        \ CONFIG register
  $08 constant FLASH_CTRL_IRQSTAT       \ IRQSTAT register
  $0C constant FLASH_CTRL_IRQMASK       \ IRQMASK register
  $10 constant FLASH_CTRL_IRQRAW        \ IRQRAW register
  $14 constant FLASH_CTRL_SIZE          \ SIZE register
  $18 constant FLASH_CTRL_ADDRESS       \ ADDRESS register
  $24 constant FLASH_CTRL_LFSRVAL       \ LFSRVAL register
  $34 constant FLASH_CTRL_PAGEPROT0     \ PAGEPROT0 register
  $38 constant FLASH_CTRL_PAGEPROT1     \ PAGEPROT1 register
  $40 constant FLASH_CTRL_DATA0         \ DATA0 register
  $44 constant FLASH_CTRL_DATA1         \ DATA1 register
  $48 constant FLASH_CTRL_DATA2         \ DATA2 register
  $4C constant FLASH_CTRL_DATA3         \ DATA3 register

: FLASH_CTRL_DEF ; [then]
