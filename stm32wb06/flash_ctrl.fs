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
    $01 constant FLASH_CTRL_REMAP               \ [0x01] Bit to redirect boot area on SRAM0.
    $02 constant FLASH_CTRL_DIS_GROUP_WRITE     \ [0x02] Burst write Control: - 0 : burst write allowed - 1 : burst write forbidden
    $04 constant FLASH_CTRL_WAIT_STATES         \ [0x04 : 2] Number of wait states to be inserted on Flash read (AHB accesses)
  [then]


  [ifdef] FLASH_CTRL_IRQSTAT_DEF
    \
    \ @brief IRQSTAT register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_CTRL_CMDDONE_MIS         \ [0x00] Command done masked interrupt status.
    $01 constant FLASH_CTRL_CMDSTART_MIS        \ [0x01] Command started masked interrupt status.
    $02 constant FLASH_CTRL_CMDERR_MIS          \ [0x02] Command error masked interrupt status.
    $03 constant FLASH_CTRL_ILLCMD_MIS          \ [0x03] Illegal command masked interrupt status
    $04 constant FLASH_CTRL_READOK_MIS          \ [0x04] Mass read OK masked interrupt status.
  [then]


  [ifdef] FLASH_CTRL_IRQMASK_DEF
    \
    \ @brief IRQMASK register
    \ Address offset: 0x0C
    \ Reset value: 0x0000003F
    \
    $00 constant FLASH_CTRL_CMDDONEM            \ [0x00] Command done mask
    $01 constant FLASH_CTRL_CMDSTARTM           \ [0x01] Command started mask.
    $02 constant FLASH_CTRL_CMDERRM             \ [0x02] Command error mask.
    $03 constant FLASH_CTRL_ILLCMDM             \ [0x03] Illegal command mask.
    $04 constant FLASH_CTRL_READOKM             \ [0x04] Mass read OK mask.
  [then]


  [ifdef] FLASH_CTRL_IRQRAW_DEF
    \
    \ @brief IRQRAW register
    \ Address offset: 0x10
    \ Reset value: 0x00000001
    \
    $00 constant FLASH_CTRL_CMDDONE_RIS         \ [0x00] Command done raw/unmasked interrupt status. This it is set once the requested command execution is completed. Cleared by writing 1.
    $01 constant FLASH_CTRL_CMDSTART_RIS        \ [0x01] Command started raw/unmasked interrupt status. This bit is set once the requested command execution has started.
    $02 constant FLASH_CTRL_CMDERR_RIS          \ [0x02] Command error raw/unmasked interrupt status
    $03 constant FLASH_CTRL_ILLCMD_RIS          \ [0x03] Illegal command raw/unmasked interrupt status.
    $04 constant FLASH_CTRL_READOK_RIS          \ [0x04] Mass read OK raw/unmasked interrupt status
  [then]


  [ifdef] FLASH_CTRL_SIZE_DEF
    \
    \ @brief SIZE register
    \ Address offset: 0x14
    \ Reset value: 0x0000FFFF
    \
    $00 constant FLASH_CTRL_FLASH_SIZE          \ [0x00 : 16] Maximum valid address for flash memory: - 00 : 0x0BFFF (192kb) - 01 : 0x0FFFF (256kb) - 10 : 0x17FFF (384kb) - 11 : 0x1FFFF (512kb)
    $11 constant FLASH_CTRL_RAM_SIZE            \ [0x11 : 2] RAM memory size selection: - 00 : 32kb - 01 : 32kb - 10 : 48kb - 11 : 64kb
    $13 constant FLASH_CTRL_FLASH_SECURE        \ [0x13] Flash memory protection (0: no key present, 1: key present)
    $14 constant FLASH_CTRL_SWD_DISABLE         \ [0x14] Flash+SWD protection: 0: No SWD protection (refer to FLASH_SECURE) 1: Flash and SWD protected
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
    $00 constant FLASH_CTRL_SEG0                \ [0x00 : 16] First segment definition.
    $10 constant FLASH_CTRL_SEG1                \ [0x10 : 16] Second segment definition. See SEG0 description for details on SEG1[31:16] content
  [then]


  [ifdef] FLASH_CTRL_PAGEPROT1_DEF
    \
    \ @brief PAGEPROT1 register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_CTRL_SEG2                \ [0x00 : 16] Third segment definition. See PAGEPROT0 SEG0 description for details on SEG2[15:0] content
    $10 constant FLASH_CTRL_SEG3                \ [0x10 : 16] Fourth segment definition. See PAGEPROT0 SEG0 description for details on SEG3[15:0] content.
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
